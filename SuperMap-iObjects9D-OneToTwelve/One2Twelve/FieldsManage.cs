using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMap.Data;
using SuperMap.UI;
using SuperMap.Mapping;
using System.Windows.Forms;

namespace One2Twelve
{
    public class FieldsManage
    {
        public void AddFieldInDataset(WorkspaceControl wsControl,Workspace fm_workspace)
        {
            FieldInfo fieldInfo = new FieldInfo();
            switch (Common.tmpFieldType)
            {
                case "16位整型":
                    fieldInfo.Type = FieldType.Int16;
                    fieldInfo.Name = Common.tmpFieldName;
                    break;
                case "32位整型":
                    fieldInfo.Type = FieldType.Int32;
                    fieldInfo.Name = Common.tmpFieldName;
                    break;
                case "64位整型":
                    fieldInfo.Type = FieldType.Int64;
                    fieldInfo.Name = Common.tmpFieldName;
                    break;
                case "双精度":
                    fieldInfo.Type = FieldType.Double;
                    fieldInfo.Name = Common.tmpFieldName;
                    break;
                case "单精度":
                    fieldInfo.Type = FieldType.Single;
                    fieldInfo.Name = Common.tmpFieldName;
                    break;
                case "文本型":
                    fieldInfo.Type = FieldType.Text;
                    fieldInfo.Name = Common.tmpFieldName;
                    break;
                case "宽字符":
                    fieldInfo.Type = FieldType.WText;
                    fieldInfo.Name = Common.tmpFieldName;
                    break;
                case "字符型":
                    fieldInfo.Type = FieldType.Char;
                    fieldInfo.Name = Common.tmpFieldName;
                    break;
                case "布尔":
                    fieldInfo.Type = FieldType.Boolean;
                    fieldInfo.Name = Common.tmpFieldName;
                    break;
                case "日期":
                    fieldInfo.Type = FieldType.DateTime;
                    fieldInfo.Name = Common.tmpFieldName;
                    break;
                case "字节":
                    fieldInfo.Type = FieldType.Byte;
                    fieldInfo.Name = Common.tmpFieldName;
                    break;
                case "二进制型":
                    fieldInfo.Type = FieldType.LongBinary;
                    fieldInfo.Name = Common.tmpFieldName;
                    break;
            }
            DatasetVector tmpDsv = fm_workspace.Datasources[wsControl.WorkspaceTree.SelectedNode.Parent.Name].Datasets[wsControl.WorkspaceTree.SelectedNode.Name] as DatasetVector;
            tmpDsv.FieldInfos.Add(fieldInfo);
            MessageBox.Show("新建字段成功");
            Common.tmpFieldName = "";
        }

        public List<string> deleteFileinDataset_PreLoadForm(WorkspaceControl wsControl,Workspace fm_workspace)
        {
            List<string> fieldList = new List<string>();
            DatasetVector tmpDatasetVector = fm_workspace.Datasources[wsControl.WorkspaceTree.SelectedNode.Parent.Name].Datasets[wsControl.WorkspaceTree.SelectedNode.Name] as DatasetVector;
            int tmpFieldCount = tmpDatasetVector.FieldCount;
            for (int t = 0; t < tmpFieldCount; t++)
            {
                fieldList.Add(tmpDatasetVector.FieldInfos[t].Name);
            }
            return fieldList;
        }

        public void deleteFieldinDataset(WorkspaceControl wsControl, string tmpFieldName,Workspace fm_workspace)
        {
            DatasetVector tmpDSV = fm_workspace.Datasources[wsControl.WorkspaceTree.SelectedNode.Parent.Name].Datasets[wsControl.WorkspaceTree.SelectedNode.Name] as DatasetVector;

            if (!tmpDSV.FieldInfos[tmpFieldName].IsSystemField)
            {

                tmpDSV.FieldInfos.Remove(tmpFieldName);
                MessageBox.Show("字段删除成功");
            }
            else
            {
                MessageBox.Show("字段删除失败，该字段为系统字段");
            }
        }

        public List<string> renameFieldinDataset_PreLoadForm(WorkspaceControl wsControl,Workspace fm_workspace)
        {
            List<string> fieldList = new List<string>();
            DatasetVector tmpDatasetVector = fm_workspace.Datasources[wsControl.WorkspaceTree.SelectedNode.Parent.Name].Datasets[wsControl.WorkspaceTree.SelectedNode.Name] as DatasetVector;
            int tmpFieldCount = tmpDatasetVector.FieldCount;
            for (int t = 0; t < tmpFieldCount; t++)
            {
                fieldList.Add(tmpDatasetVector.FieldInfos[t].Name);
            }
            return fieldList;
        }

        public void renameFieldinDataset(WorkspaceControl wsControl, string renamefieldName, string BeRenamedFieldName,Workspace fm_workspace)
        {
            DatasetVector tmpDSV = fm_workspace.Datasources[wsControl.WorkspaceTree.SelectedNode.Parent.Name].Datasets[wsControl.WorkspaceTree.SelectedNode.Name] as DatasetVector;
            FieldInfo tmpFieldInfo = new FieldInfo();
            tmpDSV.FieldInfos[BeRenamedFieldName].Caption = renamefieldName;
            MessageBox.Show("字段重命名成功");
        }
    }
}
