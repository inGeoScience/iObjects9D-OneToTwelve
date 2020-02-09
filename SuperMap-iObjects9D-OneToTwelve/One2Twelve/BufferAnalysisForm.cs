using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperMap.Data;
using SuperMap.Mapping;
using SuperMap.UI;
using SuperMap.Analyst.SpatialAnalyst;

namespace One2Twelve
{
    public partial class BufferAnalysisForm : Form
    {

        
        private Workspace bufferWorkspace;
        private MapControl bufferMapcontrol;
        private bool doPointBuffer = false;
        private bool doLineBuffer = false;
        Recordset resultInBuffer = null;
        private string tmpDsAlias;
        private bool anyPointLayer = false;
        private bool anyLineLayer = false;

        public BufferAnalysisForm(Workspace workspace, MapControl mapControl, DataGridView dg)
        {
            InitializeComponent();

            Recordset bufferRs = null;
            bufferMapcontrol = mapControl;
            bufferWorkspace = workspace;
            int b = 0;
            for (b = 0; b < bufferMapcontrol.Map.Layers.Count; b++)
            {
                if (bufferMapcontrol.Map.Layers[b].Selection != null && bufferMapcontrol.Map.Layers[b].Selection.Count != 0)
                {
                    bufferRs = bufferMapcontrol.Map.Layers[b].Selection.ToRecordset();
                    tmpDsAlias = bufferMapcontrol.Map.Layers[b].Dataset.Datasource.Alias;
                }
            }
            Geometry geo = bufferRs.GetGeometry();
            if (geo.Type == GeometryType.GeoPoint)
            {
                rightDistance_Textbox.Enabled = false;
                leftDistance_Textbox.Enabled = false;
                doPointBuffer = true;
            }
            else if (geo.Type == GeometryType.GeoLine)
            {
                bufferRadius_Textbox.Enabled = false;
                doLineBuffer = true;
            }
        }

        private void confirmBuffer_button_Click(object sender, EventArgs e)
        {
            if (doLineBuffer)
            {
                CreateLineBuffer(Convert.ToDouble(leftDistance_Textbox.Text), Convert.ToDouble(rightDistance_Textbox.Text),datasetName_Textbox.Text);
            }
            else if (doPointBuffer)
            {
                CreatePointBuffer(Convert.ToDouble(bufferRadius_Textbox.Text),datasetName_Textbox.Text);
            }
            this.Close();
        }

        private void CreateLineBuffer(double left, double right,string datasetName)
        {
            int q = 0;
            Recordset bufferRs = null;
            while (bufferMapcontrol.Map.Layers[q].Selection.Count <= 0)
            {
                q++;
            }
            bufferRs = bufferMapcontrol.Map.Layers[q].Selection.ToRecordset();
            Geometry tmpGeo = bufferRs.GetGeometry();
            BufferAnalystParameter bPara = new BufferAnalystParameter();
            bPara.EndType = BufferEndType.Flat;
            bPara.LeftDistance = left;
            bPara.RightDistance = right;
            DatasetVectorInfo bufferDsvInfo = new DatasetVectorInfo(datasetName, DatasetType.Region);
            DatasetVector bufferDsv = bufferWorkspace.Datasources[0].Datasets.Create(bufferDsvInfo);
            BufferAnalyst.CreateBuffer(bufferRs, bufferDsv, bPara, true, true);
            
            MessageBox.Show("缓冲区分析成功");
            //doLineBuffer = false;
            int i = 0;
            int e = 0;
            DatasetVector tmpPointDsV = null;

            for (i = 0; i < bufferWorkspace.Datasources.Count; i++)
            {
                for (e = 0; e < bufferWorkspace.Datasources[i].Datasets.Count; e++)
                {
                    if (bufferWorkspace.Datasources[i].Datasets[e].Type == DatasetType.Point)
                    {
                        anyPointLayer = true;
                        tmpPointDsV = bufferWorkspace.Datasources[i].Datasets[e] as DatasetVector;
                        resultInBuffer = tmpPointDsV.Query(tmpGeo, left, CursorType.Dynamic);
                        BufferResultDataGridViewPropertyForm bufferResultDataGridView_Form = new BufferResultDataGridViewPropertyForm(resultInBuffer);
                        confirmBuffer_button.Enabled = false;
                        this.Hide();
                        bufferResultDataGridView_Form.ShowDialog();
                        this.Close();
                    }
                }
            }

            confirmBuffer_button.Enabled = false;

            if (!anyPointLayer)
            {
                MessageBox.Show("工作空间不存在点数据集");
                anyPointLayer = false;
            }

            doLineBuffer = false;
        }

        private void CreatePointBuffer(double radius,string datasetName)
        {
            int q = 0;
            Recordset bufferRs = null;
            while (bufferMapcontrol.Map.Layers[q].Selection.Count <= 0)
            {
                q++;
            }
            bufferRs = bufferMapcontrol.Map.Layers[q].Selection.ToRecordset();
            Geometry tmpGeo = bufferRs.GetGeometry();
            BufferAnalystParameter bPara = new BufferAnalystParameter();
            bPara.EndType = BufferEndType.Round;
            bPara.RadiusUnit = BufferRadiusUnit.Meter;
            bPara.LeftDistance = radius;
            DatasetVectorInfo bufferDsvInfo = new DatasetVectorInfo(datasetName, DatasetType.Region);
            DatasetVector bufferDsv = bufferWorkspace.Datasources[bufferMapcontrol.Map.Layers[q].Dataset.Datasource.Alias].Datasets.Create(bufferDsvInfo);
            BufferAnalyst.CreateBuffer(bufferRs, bufferDsv, bPara, true, true);
            MessageBox.Show("缓冲区分析成功");
            Common.namesOfExistedDatasets.Add(bufferMapcontrol.Map.Layers[q].Dataset.Datasource.Alias + "." + datasetName);

            int i = 0;
            int e = 0;
            DatasetVector tmpLineDsV = null;

            for (i = 0; i < bufferWorkspace.Datasources.Count; i++)
            {
                for (e = 0; e < bufferWorkspace.Datasources[i].Datasets.Count; e++)
                {
                    if (bufferWorkspace.Datasources[i].Datasets[e].Type == DatasetType.Line)
                    {
                        anyLineLayer = true;
                        tmpLineDsV = bufferWorkspace.Datasources[i].Datasets[e] as DatasetVector;
                        resultInBuffer = tmpLineDsV.Query(tmpGeo, radius, CursorType.Dynamic);
                        BufferResultDataGridViewPropertyForm bufferResultDataGridView_Form = new BufferResultDataGridViewPropertyForm(resultInBuffer);
                        confirmBuffer_button.Enabled = false;
                        this.Hide();
                        bufferResultDataGridView_Form.ShowDialog();
                        this.Close();
                    }
                }
            }

            confirmBuffer_button.Enabled = false;

            if (!anyLineLayer)
            {
                MessageBox.Show("工作空间不存在线数据集");
                anyLineLayer = false;
            }

            doPointBuffer = false;
        }

        private void datasetName_Textbox_TextChanged(object sender, EventArgs e)
        {
            if (datasetName_Textbox.Text != "" && !Common.namesOfExistedDatasets.Contains(tmpDsAlias+"."+datasetName_Textbox.Text))
            {
                confirmBuffer_button.Enabled = true;
            }
            else
            {
                confirmBuffer_button.Enabled = false;
            }
        }
    }
}
