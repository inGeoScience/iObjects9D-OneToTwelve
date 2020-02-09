using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperMap.Data.Topology;
using SuperMap.UI;
using SuperMap.Data;
using SuperMap.Mapping;

namespace One2Twelve
{
    public partial class DobuleCheckTopo : Form
    {
        private Workspace workspace_Dou = One2Twelve.workspace_main;
        private MapControl mapcontrol_Dou = One2Twelve.mapcontrol_main;
        public DatasetVector Dtv_result;
        public static DatasetVector Dtv_ana;
        public static DatasetVector Dtv_check;
        private Class1 run;
        private LayersControl layerscontrol_Duo;

        public DobuleCheckTopo(Workspace wkSpace, MapControl mapControl,LayersControl layerscon)
        {
            InitializeComponent();

            layerscontrol_Duo = layerscon;
            workspace_Dou = wkSpace;
            mapcontrol_Dou = mapControl;
            run = new Class1(workspace_Dou, mapcontrol_Dou,layerscontrol_Duo);

            Datasets datasets = workspace_Dou.Datasources[0].Datasets;
            if (datasets.Count >= 2)
            {
                //初始化ComboBox
                InitailCBB(datasets);
            }
            else
            {
                MessageBox.Show("请打开至少两个面数据集");
            }
        }

        private void InitailCBB(Datasets datasets)
        {
            CBB_CheckDt.DropDownStyle = ComboBoxStyle.DropDownList;
            CBB_ReDt.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (Dataset dataset in datasets)
            {
                if (dataset.Type == DatasetType.Region)
                {
                    CBB_CheckDt.Items.Add(dataset.Name);
                    CBB_ReDt.Items.Add(dataset.Name);
                }
            }
            CBB_ReDt.SelectedIndex = 0;
            CBB_CheckDt.SelectedIndex = 0;
        }

        private void DobuleCheckTopo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CBB_CheckDt.Text != CBB_ReDt.Text)
                {
                    DatasetVector[] Dtvs = new DatasetVector[2];
                    Dtvs[0] = workspace_Dou.Datasources[0].Datasets[CBB_CheckDt.Text] as DatasetVector;
                    Dtv_ana = Dtvs[0];
                    Dtvs[1] = workspace_Dou.Datasources[0].Datasets[CBB_ReDt.Text] as DatasetVector;
                    Dtv_check = Dtvs[1];

                    //进行拓扑检查
                    Dtvs = run.Ispropress_Dou(Dtvs);

                    if (Dtvs[0] == null || Dtvs[1] == null)
                    {
                        MessageBox.Show("预处理失败");
                    }
                    else
                    {
                        //进行拓扑处理
                        Dtv_result = run.IsValidate_Dou(Dtvs);

                        if (Dtv_result == null)
                        {
                            MessageBox.Show("拓扑差错失败");
                        }
                        else
                        {
                            //如果差错成功显示在地图上
                            LayerSettingVector layerSettingVector = new LayerSettingVector();
                            GeoStyle geoStyle = new GeoStyle();
                            geoStyle.FillForeColor = Color.Orange;
                            layerSettingVector.Style = geoStyle;

                            mapcontrol_Dou.Map.Layers.Add(Dtv_result, layerSettingVector, true);
                            mapcontrol_Dou.Map.Refresh();

                            if (Dtv_result.RecordCount == 0)
                            {
                                MessageBox.Show("拓扑错误检查成功,没有重叠部分！");
                            }
                            else
                            {
                                MessageBox.Show("拓扑差错成功,有重叠部分");
                            }
                            this.Close();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("请选择两个不同的面数据集！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:" + ex.Message + ex.StackTrace);
            }
        }

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // DobuleCheckTopo
        //    // 
        //    this.ClientSize = new System.Drawing.Size(282, 253);
        //    this.Name = "DobuleCheckTopo";
        //    this.Load += new System.EventHandler(this.DobuleCheckTopo_Load_1);
        //    this.ResumeLayout(false);

        //}

        private void DobuleCheckTopo_Load_1(object sender, EventArgs e)
        {

        }

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // DobuleCheckTopo
        //    // 
        //    this.ClientSize = new System.Drawing.Size(282, 253);
        //    this.Name = "DobuleCheckTopo";
        //    this.Load += new System.EventHandler(this.DobuleCheckTopo_Load_2);
        //    this.ResumeLayout(false);

        //}

        private void DobuleCheckTopo_Load_2(object sender, EventArgs e)
        {

        }
    }
}
