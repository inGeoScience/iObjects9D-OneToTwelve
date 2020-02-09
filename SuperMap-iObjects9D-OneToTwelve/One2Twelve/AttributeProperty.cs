using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperMap.UI;
using SuperMap.Data;
using SuperMap.Mapping;

namespace One2Twelve
{
    public partial class AttributeProperty : Form
    {
        private Workspace attWorkspace;
        private MapControl attMapControl;
        private SuperMap.Data.GeoLine m_geoLine;
        private SuperMap.Data.GeoPoint m_geoPoint;
        private bool isGeoLine = false;
        private bool isGeoPoint = false;
        private int q = 0;

        public AttributeProperty()
        {
            InitializeComponent();
        }

        public void Init(Workspace workspace, MapControl mapControl)
        {
            attMapControl = mapControl;
            attWorkspace = workspace;
            loadDataGridViewProperty();
        }

        private void loadDataGridViewProperty()
        {
            int i = 0;
            Recordset tmpRs = null;
            //tmpRs = attMapControl.Map.Layers[0].Selection.ToRecordset();
            while (attMapControl.Map.Layers[q].Selection.Count <= 0)
            {
                q++;
            }
            tmpRs = attMapControl.Map.Layers[q].Selection.ToRecordset();
            FieldInfos tmpFieldsInfos = tmpRs.GetFieldInfos();
            tmpDataGridViewProperty.RowCount = tmpRs.FieldCount;
            for (i = 0; i < tmpRs.FieldCount; i++)
            {
                tmpDataGridViewProperty.Rows[i].ReadOnly = tmpFieldsInfos[i].IsSystemField || tmpRs.IsReadOnly;
                tmpDataGridViewProperty.Rows[i].Cells[0].Value = tmpFieldsInfos[i].Name;
                try
                {
                    tmpDataGridViewProperty.Rows[i].Cells[1].Value = tmpRs.GetFieldValue(i);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            Geometry geo = tmpRs.GetGeometry();

            if (geo is SuperMap.Data.GeoLine)
            {
                m_geoLine = geo as SuperMap.Data.GeoLine;
                isGeoLine = true;
            }
            else if (geo is SuperMap.Data.GeoPoint)
            {
                m_geoPoint = geo as SuperMap.Data.GeoPoint;
                isGeoPoint = true;
            }

        }

        private void AttributeProperty_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Modify_button_Click(object sender, EventArgs e)
        {
            Recordset tmpRs = null;
            if (attMapControl.Map.Layers[q].Selection != null && attMapControl.Map.Layers[q].Selection.Count != 0)
            {
                tmpRs = attMapControl.Map.Layers[q].Selection.ToRecordset();
                for (int i = 0; i < tmpDataGridViewProperty.Rows.Count; i++)
                {
                    if (tmpDataGridViewProperty.Rows[i].Cells[1] != null)
                    {
                        if (Convert.ToString(tmpDataGridViewProperty.Rows[i].Cells[1].Value) != Convert.ToString(tmpRs.GetFieldValue(i)))
                        {
                            Object newValue = tmpDataGridViewProperty.Rows[i].Cells[1].Value;
                            DatasetVector tmpDsV = attMapControl.Map.Layers[q].Selection.Dataset as DatasetVector;
                            Recordset tmpRs1 = null;
                            FieldInfo tmpFieldInfo = tmpDsV.FieldInfos[tmpDataGridViewProperty.Rows[i].Cells[0].Value.ToString()];
                            FieldType tmpFieldType = tmpFieldInfo.Type;
                            switch (tmpFieldType)
                            {
                                case FieldType.Int16:
                                    newValue = Int16.Parse((String)newValue);
                                    break;
                                case FieldType.Int32:
                                    newValue = Int32.Parse((String)newValue);
                                    break;
                                case FieldType.Int64:
                                    newValue = Int64.Parse((String)newValue);
                                    break;
                                case FieldType.Double:
                                    newValue = Double.Parse((String)newValue);
                                    break;
                                case FieldType.DateTime:
                                    newValue = DateTime.Parse((String)newValue);
                                    break;
                                default:
                                    break;
                            }

                            if (isGeoLine)
                            {
                                tmpRs1 = tmpDsV.Query("SMID=" + m_geoLine.ID, CursorType.Dynamic);
                                tmpRs1.Edit();
                                tmpRs1.SetFieldValue(tmpDataGridViewProperty.Rows[i].Cells[0].Value.ToString(), newValue);
                                tmpRs1.Update();
                                MessageBox.Show("修改成功");
                                q = 0;
                                //isGeoLine = false;
                            }
                            else if (isGeoPoint)
                            {
                                tmpRs1 = tmpDsV.Query("SMID=" + m_geoPoint.ID, CursorType.Dynamic);
                                tmpRs1.Edit();
                                tmpRs1.SetFieldValue(tmpDataGridViewProperty.Rows[i].Cells[0].Value.ToString(), newValue);
                                tmpRs1.Update();
                                MessageBox.Show("修改成功");
                                q = 0;
                                //isGeoPoint = false;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("yes");
                    }
                }
            }
        }

        private void AttributeProperty_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            isGeoPoint = false;
            isGeoLine = false;
        }
    }
}
