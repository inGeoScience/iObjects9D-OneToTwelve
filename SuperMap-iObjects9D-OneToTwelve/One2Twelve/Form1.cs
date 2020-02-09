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
using SuperMap.Mapping;
using SuperMap.Data;
using System.Threading;
using System.IO;
using SuperMap.Data.Conversion;
using SuperMap.Data.Topology;
using SuperMap.Realspace;
using SuperMap.Analyst.SpatialAnalyst;

namespace One2Twelve
{
    public partial class One2Twelve : Form
    {
        
        
        FieldsManage fm = new FieldsManage();
        FieldNameForm FieldName_Form = new FieldNameForm();
        DatasetNameForm DatasetName_Form = new DatasetNameForm();
        NewAndSaveUdbDataSource test;
        AttributeProperty AttributeProperty_Form = new AttributeProperty();
        public static MapControl mapcontrol_main;
        public static Workspace workspace_main;
        private DatasetVector Sour_Dtv;
        private LayersTreeNodeBase ltn;

        public One2Twelve()
        {
            InitializeComponent();


            workspaceControl1.WorkspaceTree.NodeContextMenuStrips[WorkspaceTreeNodeDataType.Datasource] = DatasourceMenuStrip;

            workspaceControl1.WorkspaceTree.NodeContextMenuStrips[WorkspaceTreeNodeDataType.Datasources] = DatasourcesMenuStrip;

            workspaceControl1.WorkspaceTree.NodeContextMenuStrips[WorkspaceTreeNodeDataType.Workspace] = workspaceMenuStrip;

            workspaceControl1.WorkspaceTree.NodeContextMenuStrips[WorkspaceTreeNodeDataType.Dataset] = EditDatasetMenuStrip;

            layersControl1.Map = mapControl1.Map;

            layersControl1.LayersTree.NodeContextMenuStrips[LayersTreeNodeDataType.Layer] = DesignMenuStrip;

            workspaceControl1.AllowDefaultAction = false;
        }

        private void 打开工作空间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //设置公用打开对话框
            //openFileDialog1.Filter = "SuperMap 工作空间文件(*.smwu)|*.smwu";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "SuperMap 工作空间文件(*.smwu)|*.smwu";
            //避免连续打开工作空间导致程序异常   
            mapControl1.Map.Close();
            workspace1.Close();
            mapControl1.Map.Refresh();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                //this.保存数据ToolStripMenuItem.Enabled = false;
                workspace1.Save();
                workspace1.Close();
                workspace1.Open(new WorkspaceConnectionInfo(openFileDialog.FileName));
                //建立MapControl与Workspace的连接
                mapControl1.Map.Workspace = workspace1;
                workspaceControl1.WorkspaceTree.Workspace = workspace1;
                mapcontrol_main = mapControl1;
                workspace_main = workspace1;
                if (workspace1.Datasources.Count > 0)
                {
                    mapControl1.Map.Layers.Add(workspace1.Datasources[0].Datasets[0], true);
                    layersControl1.Map = mapControl1.Map;
                }

                if (workspace1.Maps.Count == 0)
                {
                    MessageBox.Show("当前工作空间中不存在地图!");
                    mapControl1.Map.Workspace = workspace1;
                    return;
                }

                //打开第一幅地图
                Map map = mapControl1.Map;
                map.Workspace = workspace1;
                map.Open(workspace1.Maps[0]);

                // 将地图关联到二维图层树，使其管理其中的地图图层
                layersControl1.Map = map;

                //刷新地图窗口
                mapControl1.Map.Refresh();
            }
        }

        private void 关闭工作空间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 保存工作空间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Common.isNewEmptyWorkspace == true)
            {
                Common.isNewEmptyWorkspace = false;
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "SuperMap 工作空间文件(*.smwu)|*.smwu";
                saveFileDialog.FilterIndex = 0;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workspace1.Caption = System.IO.Path.GetFileNameWithoutExtension(saveFileDialog.FileName);
                    workspace1.Save();
                    workspace1.SaveAs(new WorkspaceConnectionInfo(saveFileDialog.FileName));
                    OpenJustSavedNewEmptyWorkspace(saveFileDialog.FileName);
                    workspaceControl1.WorkspaceTree.Refresh();
                }
            }
            else
            {
                workspace1.Save();
            }
        }

        private void 另存工作空间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "SuperMap 工作空间文件(*.smwu)|*.smwu";
            saveFileDialog.FilterIndex = 0;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workspace1.SaveAs(new WorkspaceConnectionInfo(saveFileDialog.FileName));
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {




        }


        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void buttonregin_Click(object sender, EventArgs e)
        {

        }

        private void buttonpoint_Click(object sender, EventArgs e)
        {
        }

        private void workspaceControl1_Load(object sender, EventArgs e)
        {

        }

        private void 新建数据源ToolStripMenuItem_Click(object sender, EventArgs e)
        {
                mapControl1.Dock = DockStyle.Fill;
                mapControl1.IsWaitCursorEnabled = false;
                base.Controls.Add(mapControl1);
                test = new NewAndSaveUdbDataSource(workspace1, mapControl1);

                if (Common.createUdbSuccess == true)
                {
                    //this.保存数据ToolStripMenuItem.Enabled = true;
                    //this.新建线数据集ToolStripMenuItem.Enabled = true;
                    //this.新建点数据集ToolStripMenuItem.Enabled = true;
                    //this.新建字段ToolStripMenuItem.Enabled = true;
                    //this.删除字段ToolStripMenuItem.Enabled = true;
                    //this.重命名字段ToolStripMenuItem.Enabled = true;
                    Common.createUdbSuccess = false;
                }
            //mapControl1.Dock = DockStyle.Fill;
            //mapControl1.IsWaitCursorEnabled = false;
            //base.Controls.Add(mapControl1);
            //test = new NewAndSaveUdbDataSource(workspace1, mapControl1);
            //if (workspace1.ConnectionInfo.ToString().EndsWith("Thematicmaps.smwu"))
            //{
            //    this.新建点线的矢量数据集ToolStripMenuItem.Enabled = true;
            //}

            //if (Common.createUdbSuccess == true)
            //{
            //    this.保存数据ToolStripMenuItem.Enabled = true;
            //    this.新建数据源ToolStripMenuItem.Enabled = false;
            //    this.新建线数据集ToolStripMenuItem.Enabled = true;
            //    this.新建点数据集ToolStripMenuItem.Enabled = true;
            //    Common.createUdbSuccess = false;
            //}

        }



        private void 开始编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  this.保存数据ToolStripMenuItem.Enabled = true;
            if (this.workspaceControl1.WorkspaceTree.SelectedNode != null)
            {
                string selectedname = this.workspaceControl1.WorkspaceTree.SelectedNode.Name;
                string selectnodeparent = this.workspaceControl1.WorkspaceTree.SelectedNode.Parent.Name;
                if (this.workspaceControl1.WorkspaceTree.SelectedNode.Parent.Name == "data")
                {
                    Datasource parentds = workspace1.Datasources[selectnodeparent];

                    Dataset seldt = parentds.Datasets[selectedname];

                    Layers layers = mapControl1.Map.Layers;
                    Layer layer = layers.Add(seldt, true);
                    mapControl1.Map.Refresh();
                }
                //this.开始编辑ToolStripMenuItem.Enabled = false;
                //this.编辑线ToolStripMenuItem.Enabled = true;
                //this.结束编辑ToolStripMenuItem.Enabled = true;
                //this.编辑点ToolStripMenuItem.Enabled = true;
            }
            else
            {
                MessageBox.Show("请先选择数据源");
            }

        }


        private void 编辑线ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkspaceTreeNodeBase node = workspaceControl1.WorkspaceTree.SelectedNode as WorkspaceTreeNodeBase;
            Dataset tmpDs = node.GetData() as Dataset;
            if (node.NodeType == WorkspaceTreeNodeDataType.DatasetVector)
            {
                if (tmpDs.Type == DatasetType.Line)
                {
                    Layers layers = mapControl1.Map.Layers;
                    Layer layer = layers[0];
                    layer.IsEditable = true;
                    mapControl1.Action = SuperMap.UI.Action.CreatePolyline;
                    mapControl1.Refresh();
                }
                else
                {
                    MessageBox.Show("请选择线数据集");
                }
            }
            else
            {
                MessageBox.Show("请选中数据集");
            }
        }

        private void 保存数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatasetManage dsm = new DatasetManage(workspace1, mapControl1);
            dsm.dataSourceSave();
        }

        private void 结束编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mapControl1.Action = SuperMap.UI.Action.Select2;
            mapControl1.Refresh();
        }

        private void 编辑点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkspaceTreeNodeBase node = workspaceControl1.WorkspaceTree.SelectedNode as WorkspaceTreeNodeBase;
            Dataset tmpDs = node.GetData() as Dataset;
            if (node.NodeType == WorkspaceTreeNodeDataType.DatasetVector)
            {
                if (tmpDs.Type == DatasetType.Point)
                {
                    Layers layers = mapControl1.Map.Layers;
                    Layer layer = layers[0];
                    layer.IsEditable = true;
                    mapControl1.Action = SuperMap.UI.Action.CreatePoint;
                    mapControl1.Refresh();
                    //this.选择ToolStripMenuItem.Enabled = true;
                }
                else
                {
                    MessageBox.Show("请选择点数据集");
                }
            }
            else
            {
                MessageBox.Show("请选中数据集");
            }
        }


        private void 新建点数据集ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            //this.保存数据ToolStripMenuItem.Enabled = true;
            if (workspaceControl1.WorkspaceTree.SelectedNode != null)
            {
                WorkspaceTreeNodeBase node = workspaceControl1.WorkspaceTree.SelectedNode as WorkspaceTreeNodeBase;
                if (node.NodeType == WorkspaceTreeNodeDataType.Datasource)
                {
                    DatasetManage datasetManage = new DatasetManage(workspace1, mapControl1);
                    string tmpDatasourceName = workspaceControl1.WorkspaceTree.SelectedNode.Name;
                    DatasetName_Form.ShowDialog();
                    if (DatasetName_Form.DialogResult == DialogResult.Yes)
                    {
                        datasetManage.AddPointDataset(tmpDatasourceName, layersControl1, mapControl1);
                    }
                }
                else
                {
                    MessageBox.Show("请选中数据源");
                }
            }
            else
            {
                MessageBox.Show("请选中节点");
            }
        }

        private void 新建线数据集ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.保存数据ToolStripMenuItem.Enabled = true;
            if (workspaceControl1.WorkspaceTree.SelectedNode != null)
            {
                WorkspaceTreeNodeBase node = workspaceControl1.WorkspaceTree.SelectedNode as WorkspaceTreeNodeBase;
                if (node.NodeType == WorkspaceTreeNodeDataType.Datasource)
                {
                    DatasetManage datasetManage = new DatasetManage(workspace1, mapControl1);
                    string tmpSelectedDatasourceName = workspaceControl1.WorkspaceTree.SelectedNode.Name;
                    DatasetName_Form.ShowDialog();
                    if (DatasetName_Form.DialogResult == DialogResult.Yes)
                    {
                        datasetManage.AddLineDataset(tmpSelectedDatasourceName, layersControl1);
                    }
                }
                else
                {
                    MessageBox.Show("请选中数据源");
                }
            }
            else
            {
                MessageBox.Show("请选中节点");
            }
        }

        private void selectAttributes_button_Click(object sender, EventArgs e)
        {
            Common.isInLayercontrol = false;
            Selection[] selection = mapControl1.Map.FindSelection(true);
            if (selection == null || selection.Length == 0)
            {
                MessageBox.Show("请选择要查询属性的空间对象");
                return;
            }
            Recordset recordset = selection[0].ToRecordset();
            this.dataGridView1.Columns.Clear();
            this.dataGridView1.Rows.Clear();
            for (int i = 0; i < recordset.FieldCount; i++)
            {
                String fieldName = recordset.GetFieldInfos()[i].Name;
                this.dataGridView1.Columns.Add(fieldName, fieldName);
            }
            DataGridViewRow row = null;
            while (!recordset.IsEOF)
            {
                row = new DataGridViewRow();
                for (int i = 0; i < recordset.FieldCount; i++)
                {
                    Object fieldValue = recordset.GetFieldValue(i);
                    DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                    if (fieldValue != null)
                    {
                        cell.ValueType = fieldValue.GetType();
                        cell.Value = fieldValue;
                    }
                    row.Cells.Add(cell);
                }
                this.dataGridView1.Rows.Add(row);
                recordset.MoveNext();
            }
            this.dataGridView1.Update();
            recordset.Dispose();
        }
        public static bool Delay(double delayTime)
        {
            DateTime now = DateTime.Now;
            int s;
            do
            {
                TimeSpan spand = DateTime.Now - now;
                s = spand.Milliseconds;
                Application.DoEvents();
            }
            while (s < delayTime);
            return true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 新建字段ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (workspaceControl1.WorkspaceTree.SelectedNode != null)
            {
                WorkspaceTreeNodeBase node = workspaceControl1.WorkspaceTree.SelectedNode as WorkspaceTreeNodeBase;
                if (node.NodeType == WorkspaceTreeNodeDataType.DatasetVector)
                {
                    FieldName_Form.ShowDialog();
                    if (FieldName_Form.DialogResult == DialogResult.Yes)
                    {
                        fm.AddFieldInDataset(this.workspaceControl1, workspace1);
                    }
                }
                else
                {
                    MessageBox.Show("请选中数据集");
                }
            }
            else
            {
                MessageBox.Show("请选中节点");
            }
        }

        private void 新建工作空间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mapControl1.Map.Close();
            workspace1.Close();
            mapControl1.Map.Refresh();
            WorkspaceConnectionInfo wsConnInfo = new WorkspaceConnectionInfo();
            SaveFileDialog sfWorkspaceDialog = new SaveFileDialog();
            sfWorkspaceDialog.Filter = "SuperMap 工作空间文件(*.smwu)|*.smwu";
            if (sfWorkspaceDialog.ShowDialog() == DialogResult.OK)
            {
                //this.保存数据ToolStripMenuItem.Enabled = false;
                workspace1.Save();
                workspace1.Close();
                mapControl1.Map.Workspace = workspace1;
                workspace1.SaveAs(new WorkspaceConnectionInfo(sfWorkspaceDialog.FileName));
                workspace1.Caption = System.IO.Path.GetFileNameWithoutExtension(sfWorkspaceDialog.FileName);
                workspace1.Save();
                OpenJustSavedNewEmptyWorkspace(sfWorkspaceDialog.FileName);

                if (workspace1.Maps.Count == 0)
                {
                    MessageBox.Show("当前工作空间中不存在地图!");
                    return;
                }
                Map map = mapControl1.Map;
                map.Workspace = workspace1;
                map.Open(workspace1.Maps[0]);
                layersControl1.Map = map;

                //刷新地图窗口
                mapControl1.Map.Refresh();

            }
        }

        private void 删除字段ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (workspaceControl1.WorkspaceTree.SelectedNode != null)
            {
                WorkspaceTreeNodeBase node = workspaceControl1.WorkspaceTree.SelectedNode as WorkspaceTreeNodeBase;
                if (node.NodeType == WorkspaceTreeNodeDataType.DatasetVector)
                {

                    DeleteFieldForm deleteField_Form = new DeleteFieldForm();
                    deleteField_Form.LoadCombox(fm.deleteFileinDataset_PreLoadForm(this.workspaceControl1, workspace1));
                    deleteField_Form.ShowDialog();
                    if (deleteField_Form.DialogResult == DialogResult.Yes)
                    {
                        fm.deleteFieldinDataset(this.workspaceControl1, Common.tmpFieldDeletingName, workspace1);
                    }
                }
                else
                {
                    MessageBox.Show("请选中数据集");
                }
            }
            else
            {
                MessageBox.Show("请选中节点");
            }

        }

        private void 重命名字段ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (workspaceControl1.WorkspaceTree.SelectedNode != null)
            {
                WorkspaceTreeNodeBase node = workspaceControl1.WorkspaceTree.SelectedNode as WorkspaceTreeNodeBase;
                if (node.NodeType == WorkspaceTreeNodeDataType.DatasetVector)
                {
                    FieldRenameForm fieldRename_Form = new FieldRenameForm();
                    fieldRename_Form.FieldRenameForm_PreLoad(fm.renameFieldinDataset_PreLoadForm(workspaceControl1, workspace1));
                    if (fieldRename_Form.ShowDialog() == DialogResult.Yes)
                    {
                        fm.renameFieldinDataset(workspaceControl1, Common.tmpFieldRename, Common.tmpFieldBeRenamed, workspace1);
                    }

                }
                else
                {
                    MessageBox.Show("请选中数据集");
                }
            }
            else
            {
                MessageBox.Show("请选中节点");
            }
        }

        private void 选择ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mapControl1.Map.Layers[0].IsEditable = true;
            mapControl1.Action = SuperMap.UI.Action.SelectRegion;
            mapControl1.Refresh();
        }

        private void 数据集重命名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 重命名数据集ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            workspaceControl1.WorkspaceTree.LabelEdit = true;
            workspaceControl1.WorkspaceTree.SelectedNode.BeginEdit();
            workspace1.Save();
        }

        private void 删除数据集ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            workspaceControl1.WorkspaceTree.LabelEdit = true;
            workspaceControl1.WorkspaceTree.SelectedNode.Remove();
            workspace1.Save();
        }

        private void mapControl1_ActionChanged(object sender, ActionChangedEventArgs e)
        {
            if (e.NewAction == SuperMap.UI.Action.Select2)
            {
                mapControl1.Action = SuperMap.UI.Action.Select;
            }
        }

        private void One2Twelve_Load(object sender, EventArgs e)
        {
            NewEmptyWorkspace();
        }

        private void 新建文件型工作空间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            //mapControl1.Map.Close();
            //workspace1.Close();
            //mapControl1.Map.Refresh();
            WorkspaceConnectionInfo wsConnInfo = new WorkspaceConnectionInfo();
            SaveFileDialog sfWorkspaceDialog = new SaveFileDialog();
            sfWorkspaceDialog.Filter = "SuperMap 工作空间文件(*.smwu)|*.smwu";
            if (sfWorkspaceDialog.ShowDialog() == DialogResult.OK)
            {
                mapControl1.Map.Close();
                workspace1.Close();
                mapControl1.Map.Refresh();
                Common.isNewEmptyWorkspace = false;
              //  this.保存数据ToolStripMenuItem.Enabled = false;
                workspace1.Save();
                workspace1.Close();
                mapControl1.Map.Workspace = workspace1;
                workspace1.SaveAs(new WorkspaceConnectionInfo(sfWorkspaceDialog.FileName));
                workspace1.Caption = System.IO.Path.GetFileNameWithoutExtension(sfWorkspaceDialog.FileName);
                workspace1.Save();
                OpenJustSavedNewEmptyWorkspace(sfWorkspaceDialog.FileName);

                Common.filePathOfTheWorkspace = sfWorkspaceDialog.FileName;
                Common.namesOfOpenedDatasources.Clear();
                Common.namesOfExistedDatasets.Clear();
                if (workspace1.Maps.Count == 0)
                {
                    MessageBox.Show("当前工作空间中不存在地图!");
                    return;
                }
                Map map = mapControl1.Map;
                map.Workspace = workspace1;
                map.Open(workspace1.Maps[0]);
                layersControl1.Map = map;

                //刷新地图窗口
                mapControl1.Map.Refresh();

            }
        }

        private void 打开文件型工作空间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Common.isNewEmptyWorkspace = false;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "SuperMap 工作空间文件(*.smwu)|*.smwu";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileName == Common.filePathOfTheWorkspace)
                {
                    MessageBox.Show("已打开当前工作空间");
                    return;
                }
                Common.namesOfOpenedDatasources.Clear();
                Common.namesOfExistedDatasets.Clear();
                mapControl1.Map.Close();
                workspace1.Close();
                mapControl1.Map.Refresh();
                workspace1.Save();
                workspace1.Close();
                workspace1.Open(new WorkspaceConnectionInfo(openFileDialog.FileName));
                mapControl1.Map.Workspace = workspace1;
                workspaceControl1.WorkspaceTree.Workspace = workspace1;
                workspace_main = workspace1;
                mapcontrol_main = mapControl1;

                Common.filePathOfTheWorkspace = openFileDialog.FileName;

                int tmpi,tmpq;
                if (workspace1.Datasources.Count > 0)
                {
                        for (tmpi = 0; tmpi < workspace1.Datasources.Count; tmpi++)
                        {
                            Common.namesOfOpenedDatasources.Add(workspace1.Datasources[tmpi].Alias);
                            for (tmpq = 0; tmpq < workspace1.Datasources[tmpi].Datasets.Count; tmpq++)
                            {
                                Common.namesOfExistedDatasets.Add(workspace1.Datasources[tmpi].Alias + "." + workspace1.Datasources[tmpi].Datasets[tmpq].Name);
                                mapControl1.Map.Layers.Add(workspace1.Datasources[tmpi].Datasets[tmpq], true);
                            }
                        }
                        layersControl1.Map = mapControl1.Map;
                    
                }

                mapControl1.Refresh();
                layersControl1.Refresh();

                if (workspace1.Maps.Count == 0)
                {
                    mapControl1.Map.ViewEntire();
                    MessageBox.Show("当前工作空间中不存在地图!");
                    mapControl1.Map.Workspace = workspace1;
                    return;
                }

                mapControl1.Map.ViewEntire();
                //打开第一幅地图
                Map map = mapControl1.Map;
                map.Workspace = workspace1;
                map.Open(workspace1.Maps[0]);

                // 将地图关联到二维图层树，使其管理其中的地图图层
                layersControl1.Map = map;

                //刷新地图窗口
                mapControl1.Map.Refresh();
            }
        }

        private void 保存文件型工作空间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Common.isNewEmptyWorkspace == true)
            {
                Common.isNewEmptyWorkspace = false;
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "SuperMap 工作空间文件(*.smwu)|*.smwu";
                saveFileDialog.FilterIndex = 0;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workspace1.Caption = System.IO.Path.GetFileNameWithoutExtension(saveFileDialog.FileName);
                    workspace1.Save();
                    workspace1.SaveAs(new WorkspaceConnectionInfo(saveFileDialog.FileName));
                    OpenJustSavedNewEmptyWorkspace(saveFileDialog.FileName);
                    workspaceControl1.WorkspaceTree.Refresh();
                }
            }
            else
            {
                workspace1.Save();
            }
        }

        private void 另存文件型工作空间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "SuperMap 工作空间文件(*.smwu)|*.smwu";
            saveFileDialog.FilterIndex = 0;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workspace1.SaveAs(new WorkspaceConnectionInfo(saveFileDialog.FileName));
            }
        }

        private void 关闭工作空间ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult closeDialogResult = MessageBox.Show("请问是否保存当前工作空间?", "提醒保存小助手", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (closeDialogResult == DialogResult.Yes)
            {
                if (Common.isNewEmptyWorkspace == true)
                {
                    Common.isNewEmptyWorkspace = false;
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "SuperMap 工作空间文件(*.smwu)|*.smwu";
                    saveFileDialog.FilterIndex = 0;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        workspace1.Caption = System.IO.Path.GetFileNameWithoutExtension(saveFileDialog.FileName);
                        workspace1.Save();
                        workspace1.SaveAs(new WorkspaceConnectionInfo(saveFileDialog.FileName));
                        this.Close();
                    }
                }
                else
                {
                    workspace1.Save();
                    this.Close();
                }
            }
            else if (closeDialogResult == DialogResult.No)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void NewEmptyWorkspace()
        {
            mapControl1.Map.Close();
            workspace1.Close();
            mapControl1.Map.Refresh();
            WorkspaceConnectionInfo wsConnInfo = new WorkspaceConnectionInfo();
          //  this.保存数据ToolStripMenuItem.Enabled = false;
            workspace1.Save();
            workspace1.Close();
            mapControl1.Map.Workspace = workspace1;
            //workspace1.SaveAs(new WorkspaceConnectionInfo(sfWorkspaceDialog.FileName));
            workspaceControl1.WorkspaceTree.Workspace = workspace1;
            if (workspace1.Maps.Count == 0)
            {
                return;
            }
            Map map = mapControl1.Map;
            map.Workspace = workspace1;
            map.Open(workspace1.Maps[0]);
            layersControl1.Map = map;

            //刷新地图窗口
            mapControl1.Map.Refresh();

        }

        private void OpenJustSavedNewEmptyWorkspace(string filename)
        {
            //避免连续打开工作空间导致程序异常   
            mapControl1.Map.Close();
            workspace1.Close();
            mapControl1.Map.Refresh();

            //this.保存数据ToolStripMenuItem.Enabled = false;
            workspace1.Save();
            workspace1.Close();
            workspace1.Open(new WorkspaceConnectionInfo(filename));
            mapControl1.Map.Workspace = workspace1;
            workspaceControl1.WorkspaceTree.Workspace = workspace1;
            if (workspace1.Datasources.Count > 0)
            {
                if (workspace1.Datasources[0].Datasets.Count > 0)
                {
                    mapControl1.Map.Layers.Add(workspace1.Datasources[0].Datasets[0], true);
                    layersControl1.Map = mapControl1.Map;
                }
            }

            if (workspace1.Maps.Count == 0)
            {
                mapControl1.Map.Workspace = workspace1;
                return;
            }
        }

        private void 开始编辑ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void 编辑点ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            WorkspaceTreeNodeBase node = workspaceControl1.WorkspaceTree.SelectedNode as WorkspaceTreeNodeBase;
            Dataset tmpDs = node.GetData() as Dataset;
            if (node.NodeType == WorkspaceTreeNodeDataType.DatasetVector)
            {
                if (tmpDs.Type == DatasetType.Point)
                {
                    Layers layers = mapControl1.Map.Layers;
                    Layer layer = layers[workspaceControl1.WorkspaceTree.SelectedNode.Name+"@"+workspaceControl1.WorkspaceTree.SelectedNode.Parent.Name];
                    layer.IsEditable = true;
                    mapControl1.Action = SuperMap.UI.Action.CreatePoint;
                    mapControl1.Refresh();
                    //this.选择ToolStripMenuItem.Enabled = true;
                    //EditDatasetMenuStrip.Items[4].Enabled = true;
                }
                else
                {
                    MessageBox.Show("请选择点数据集");
                }
            }
            else
            {
                MessageBox.Show("请选中数据集");
            }
        }

        private void 编辑线ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            WorkspaceTreeNodeBase node = workspaceControl1.WorkspaceTree.SelectedNode as WorkspaceTreeNodeBase;
            Dataset tmpDs = node.GetData() as Dataset;
            if (node.NodeType == WorkspaceTreeNodeDataType.DatasetVector)
            {
                if (tmpDs.Type == DatasetType.Line)
                {
                    Layers layers = mapControl1.Map.Layers;
                    Layer layer = layers[workspaceControl1.WorkspaceTree.SelectedNode.Name+"@"+workspaceControl1.WorkspaceTree.SelectedNode.Parent.Name];
                    layer.IsEditable = true;
                    mapControl1.Action = SuperMap.UI.Action.CreatePolyline;
                    mapControl1.Refresh();
                    //EditDatasetMenuStrip.Items[4].Enabled = true;
                }
                else
                {
                    MessageBox.Show("请选择线数据集");
                }
            }
            else
            {
                MessageBox.Show("请选中数据集");
            }
        }

        private void 结束编辑ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void 选择ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mapControl1.Map.Layers[0].IsEditable = true;
            mapControl1.Action = SuperMap.UI.Action.SelectRegion;
            mapControl1.Refresh();
        }

        private void 新建数据源ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mapControl1.Dock = DockStyle.Fill;
            mapControl1.IsWaitCursorEnabled = false;
            base.Controls.Add(mapControl1);
            test = new NewAndSaveUdbDataSource(workspace1, mapControl1);

            if (Common.createUdbSuccess == true)
            {
                Common.createUdbSuccess = false;
            }
            else
            {
                MessageBox.Show("创建新数据源失败");
            }
        }

        private void 新建点数据集ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (workspaceControl1.WorkspaceTree.SelectedNode != null)
            {
                WorkspaceTreeNodeBase node = workspaceControl1.WorkspaceTree.SelectedNode as WorkspaceTreeNodeBase;
                if (node.NodeType == WorkspaceTreeNodeDataType.Datasource)
                {
                    DatasetManage datasetManage = new DatasetManage(workspace1, mapControl1);
                    string tmpDatasourceName = workspaceControl1.WorkspaceTree.SelectedNode.Name;
                    DatasetName_Form.Init(workspaceControl1.WorkspaceTree.SelectedNode.Name);
                    DatasetName_Form.ShowDialog();
                    if (DatasetName_Form.DialogResult == DialogResult.Yes)
                    {
                        datasetManage.AddPointDataset(tmpDatasourceName, layersControl1, mapControl1);
                        Common.namesOfExistedDatasets.Add(tmpDatasourceName + "." + Common.tmpDatasetName);
                    }
                }
                else
                {
                    MessageBox.Show("请选中数据源");
                }
            }
            else
            {
                MessageBox.Show("请选中节点");
            }
        }

        private void 新建线数据集ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (workspaceControl1.WorkspaceTree.SelectedNode != null)
            {
                WorkspaceTreeNodeBase node = workspaceControl1.WorkspaceTree.SelectedNode as WorkspaceTreeNodeBase;
                if (node.NodeType == WorkspaceTreeNodeDataType.Datasource)
                {
                    DatasetManage datasetManage = new DatasetManage(workspace1, mapControl1);
                    string tmpSelectedDatasourceName = workspaceControl1.WorkspaceTree.SelectedNode.Name;
                    DatasetName_Form.Init(workspaceControl1.WorkspaceTree.SelectedNode.Name);
                    DatasetName_Form.ShowDialog();
                    if (DatasetName_Form.DialogResult == DialogResult.Yes)
                    {
                        datasetManage.AddLineDataset(tmpSelectedDatasourceName, layersControl1);
                        Common.namesOfExistedDatasets.Add(tmpSelectedDatasourceName + "." + Common.tmpDatasetName);
                    }
                }
                else
                {
                    MessageBox.Show("请选中数据源");
                }
            }
            else
            {
                MessageBox.Show("请选中节点");
            }
        }

        private void 保存数据ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DatasetManage dsm = new DatasetManage(workspace1, mapControl1);
            dsm.dataSourceSave();
        }

        private void 新建字段ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (workspaceControl1.WorkspaceTree.SelectedNode != null)
            {
                WorkspaceTreeNodeBase node = workspaceControl1.WorkspaceTree.SelectedNode as WorkspaceTreeNodeBase;
                if (node.NodeType == WorkspaceTreeNodeDataType.DatasetVector)
                {
                    FieldName_Form.ShowDialog();
                    if (FieldName_Form.DialogResult == DialogResult.Yes)
                    {
                        fm.AddFieldInDataset(this.workspaceControl1, workspace1);
                    }
                }
                else
                {
                    MessageBox.Show("请选中数据集");
                }
            }
            else
            {
                MessageBox.Show("请选中节点");
            }
        }

        private void 删除字段ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (workspaceControl1.WorkspaceTree.SelectedNode != null)
            {
                WorkspaceTreeNodeBase node = workspaceControl1.WorkspaceTree.SelectedNode as WorkspaceTreeNodeBase;
                if (node.NodeType == WorkspaceTreeNodeDataType.DatasetVector)
                {

                    DeleteFieldForm deleteField_Form = new DeleteFieldForm();
                    deleteField_Form.LoadCombox(fm.deleteFileinDataset_PreLoadForm(this.workspaceControl1, workspace1));
                    deleteField_Form.ShowDialog();
                    if (deleteField_Form.DialogResult == DialogResult.Yes)
                    {
                        fm.deleteFieldinDataset(this.workspaceControl1, Common.tmpFieldDeletingName, workspace1);
                    }
                }
                else
                {
                    MessageBox.Show("请选中数据集");
                }
            }
            else
            {
                MessageBox.Show("请选中节点");
            }
        }

        private void 重命名字段ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (workspaceControl1.WorkspaceTree.SelectedNode != null)
            {
                WorkspaceTreeNodeBase node = workspaceControl1.WorkspaceTree.SelectedNode as WorkspaceTreeNodeBase;
                if (node.NodeType == WorkspaceTreeNodeDataType.DatasetVector)
                {
                    FieldRenameForm fieldRename_Form = new FieldRenameForm();
                    fieldRename_Form.FieldRenameForm_PreLoad(fm.renameFieldinDataset_PreLoadForm(workspaceControl1, workspace1));
                    if (fieldRename_Form.ShowDialog() == DialogResult.Yes)
                    {
                        fm.renameFieldinDataset(workspaceControl1, Common.tmpFieldRename, Common.tmpFieldBeRenamed, workspace1);
                    }

                }
                else
                {
                    MessageBox.Show("请选中数据集");
                }
            }
            else
            {
                MessageBox.Show("请选中节点");
            }
        }

        private void 重命名数据集ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            DatasetRenameForm datasetRename_Form = new DatasetRenameForm(workspace1, workspaceControl1,layersControl1);
            if (datasetRename_Form.ShowDialog() == DialogResult.Yes)
            {
                MessageBox.Show("别名修改成功");
                layersControl1.Map.Layers.Add(workspace1.Datasources[workspaceControl1.WorkspaceTree.SelectedNode.Parent.Name].Datasets[workspaceControl1.WorkspaceTree.SelectedNode.Name],false);
                
            }
        }

        private void 删除数据集ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            layersControl1.Map.Layers.Remove(workspaceControl1.WorkspaceTree.SelectedNode.Name+"@"+workspaceControl1.WorkspaceTree.SelectedNode.Parent.Name);
            Datasource tmpDs = workspace1.Datasources[workspaceControl1.WorkspaceTree.SelectedNode.Parent.Name];
            Common.namesOfExistedDatasets.Remove(workspaceControl1.WorkspaceTree.SelectedNode.Parent.Name + "." + workspaceControl1.WorkspaceTree.SelectedNode.Name);
            tmpDs.Datasets.Delete(workspaceControl1.WorkspaceTree.SelectedNode.Name);
            layersControl1.Refresh();
            mapControl1.Refresh();
            
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void 导出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfDialog = new SaveFileDialog();
            sfDialog.Filter = "Shapefile 数据文件(*.shp)|*.shp";
            if (sfDialog.ShowDialog() == DialogResult.OK)
            {
                ExportSetting tmpES = new ExportSetting(workspace1.Datasources[workspaceControl1.WorkspaceTree.SelectedNode.Parent.Name].Datasets[workspaceControl1.WorkspaceTree.SelectedNode.Name], sfDialog.FileName, FileType.SHP);
                DataExport tmpDE = new DataExport();
                tmpDE.ExportSettings.Add(tmpES);
                tmpDE.Run();
            }
        }


        private void 打开数据源ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofDialog = new OpenFileDialog();
            ofDialog.Filter = "SuperMap 文件型数据源(*.udb)|*.udb";
            if (ofDialog.ShowDialog() == DialogResult.OK)
            {
                DatasourceConnectionInfo tmpDsConnInfo = new DatasourceConnectionInfo();
                tmpDsConnInfo.Server = @ofDialog.FileName;
                tmpDsConnInfo.EngineType = EngineType.UDB;
                Datasource tmpGetAlias = new Datasource(EngineType.UDB);
                tmpDsConnInfo.Alias = System.IO.Path.GetFileNameWithoutExtension(ofDialog.FileName);
                if (Common.namesOfOpenedDatasources.Contains(tmpDsConnInfo.Alias))
                {
                    MessageBox.Show("已经打开该数据源");
                    return;
                }
                Datasource tmpDs = workspace1.Datasources.Open(tmpDsConnInfo);
                Common.namesOfOpenedDatasources.Add(tmpDsConnInfo.Alias);
                workspaceControl1.Refresh();
                int tmpi;
                if (workspace1.Datasources.Count > 0)
                {
                    for (tmpi = 0; tmpi < workspace1.Datasources[tmpDs.Alias].Datasets.Count; tmpi++)
                    {
                        Common.namesOfExistedDatasets.Add(tmpDs.Alias + "." + workspace1.Datasources[tmpDs.Alias].Datasets[tmpi].Name);
                        mapControl1.Map.Layers.Add(workspace1.Datasources[workspaceControl1.WorkspaceTree.SelectedNode.Name].Datasets[tmpi], true);
                    }
                    layersControl1.Map = mapControl1.Map;
                    mapControl1.Refresh();
                    layersControl1.Refresh();
                }
            }
        }

        private void 导入shpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofDialog = new OpenFileDialog();
            ofDialog.Filter = "Shapefile 空间文件(*.shp)|*.shp";
            if (ofDialog.ShowDialog() == DialogResult.OK)
            {
                DataImport tmpDI = new DataImport();
                ImportSettingSHP tmpIsShp = new ImportSettingSHP();
                tmpIsShp.IsImportEmptyDataset = true;
                tmpIsShp.ImportMode = ImportMode.None;
                tmpIsShp.SourceFilePath = @ofDialog.FileName;
                tmpIsShp.TargetDatasource = workspace1.Datasources[workspaceControl1.WorkspaceTree.SelectedNode.Name];
                tmpIsShp.TargetDatasetName = System.IO.Path.GetFileNameWithoutExtension(ofDialog.FileName);
                tmpDI.ImportSettings.Add(tmpIsShp);
                tmpDI.Run();
                Common.namesOfExistedDatasets.Add(workspaceControl1.WorkspaceTree.SelectedNode.Parent.Name + "." + System.IO.Path.GetFileNameWithoutExtension(ofDialog.FileName));
                workspaceControl1.Refresh();
                mapControl1.Refresh();
                
                if (workspace1.Datasources.Count > 0)
                {
                    if (workspace1.Datasources[workspaceControl1.WorkspaceTree.SelectedNode.Parent.Name].Datasets.Count > 0)
                    {
                        mapControl1.Map.Layers.Add(workspace1.Datasources[workspaceControl1.WorkspaceTree.SelectedNode.Parent.Name].Datasets[System.IO.Path.GetFileNameWithoutExtension(ofDialog.FileName)], true);
                        layersControl1.Map = mapControl1.Map;
                        mapControl1.Refresh();
                        layersControl1.Refresh();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void GetAttribute_Button_Click(object sender, EventArgs e)
        {
            if (mapControl1.Map.Layers.Count > 0)
            {
                Selection[] selection = mapControl1.Map.FindSelection(false);
                Selection s1 = selection[0];
                if (s1.Count == 0)
                {
                    MessageBox.Show("请选中数据");
                }
                else
                {
                    AttributeProperty_Form.Init(workspace1, mapControl1);

                    AttributeProperty_Form.ShowDialog();
                }
                
            }
            else
            {
                MessageBox.Show("请添加图层");
            }
            

        }
        public DatasetVector IsValidate()
        {
            //设置输出数据源
            Datasource outputDts = workspace1.Datasources[0];

            //获取拓扑错误数据集名
            if (outputDts.Datasets.Contains("TopoError"))
            {
                workspace1.Datasources[0].Datasets.Delete("TopoError");
            }
            //进行拓扑检查
            DatasetVector datasetVector = TopologyValidator.Validate(Sour_Dtv, Sour_Dtv, TopologyRule.LineNoDangles, 0.1, null, outputDts,
                                       "TopoError");
            return datasetVector;
        }

        public bool Ispropress(DatasetVector dtv)
        {
            bool result = false;
            try
            {
                Sour_Dtv = dtv;

                //设置进行预处理的数据集
                TopologyDatasetRelationItem topoItem = new TopologyDatasetRelationItem(dtv);
                TopologyDatasetRelationItem[] items = { topoItem };

                //处理时的容差控制
                double Tol = dtv.Tolerance.Fuzzy;

                result = TopologyValidator.Preprocess(items, Tol);

                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:" + ex.Message + ex.StackTrace);
            }
            return result;
        }


        private void 拓扑检查ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                if (mapControl1.Map.Layers.Count != 0)
                {
                    //进行拓扑预处理

                    if (mapControl1.Map.Layers.Count != 0)
                    {

                        DatasetVector datasetVector = mapControl1.Map.Layers[0].Dataset as DatasetVector;
                        if (datasetVector.Type == DatasetType.Line)
                        {
                            //拓扑预处理
                            bool propress_result = Ispropress(datasetVector);

                            if (propress_result)
                            {
                                DatasetVector datasetV = IsValidate();
                                if (datasetV != null)
                                {
                                    MessageBox.Show("拓扑检查完成！");
                                }
                            }
                            else
                            {
                                MessageBox.Show("拓扑检查失败！");
                            }
                        }
                        else
                        {
                            MessageBox.Show("请先打开一个线数据集");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("图层不能为空");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:" + ex.Message + ex.StackTrace);
            }
        }


        public bool TopologyPro(DatasetVector Mt_dtv)
        {
            bool resultPro = false;
            try
            {
                //设置拓扑处理类
                TopologyProcessingOptions options = new TopologyProcessingOptions();
                options.AreAdjacentEndpointsMerged = true;
                options.AreDuplicatedLinesCleaned = true;
                options.AreLinesIntersected = true;
                options.AreOvershootsCleaned = true;
                options.AreRedundantVerticesCleaned = true;
                options.AreUndershootsExtended = true;
                options.UndershootsTolerance = 0.1;

                //进行拓扑处理
                resultPro = TopologyProcessing.Clean(Mt_dtv, options);
                return resultPro;

            }
            catch (Exception ex)
            {
                MessageBox.Show("error:" + ex.Message + ex.StackTrace);
            }

            return resultPro;

        }

        private void 拓扑处理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Layers layers = mapControl1.Map.Layers;
                int num = 0;

                foreach (Layer layer in layers)
                {
                    DatasetVector Dtv_Mt = layer.Dataset as DatasetVector;
                    if (Dtv_Mt.Type == DatasetType.Line)
                    {
                        num = 1;
                        bool result = TopologyPro(Dtv_Mt);
                        if (result)
                        {
                            MessageBox.Show("拓扑处理完成！");
                            break;
                        }
                        else
                        {
                            MessageBox.Show("拓扑处理失败");
                        }
                    }
                }
                if (num != 1)
                {
                    MessageBox.Show("请打开一个先数据集");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:" + ex.Message + ex.StackTrace);
            }
        }

        public DatasetVector PickUpBorder(DatasetVector Dtv_PickUpBorder)
        {
            Datasource Dts = Dtv_PickUpBorder.Datasource;

            if (Dts.Datasets.Contains("RegionBorder"))
            {
                layersControl1.Map.Layers.Remove("RegionBorder" + "@" + Dts.Alias);
                Dts.Datasets.Delete("RegionBorder");
            }
            DatasetVector Dtv_result = TopologyProcessing.PickupBorder(Dtv_PickUpBorder, Dts, "RegionBorder", true);

            return Dtv_result;
        }

        private void 提取面边界ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int num = 0;
                Layers layers = mapControl1.Map.Layers;
                foreach (Layer layer in layers)
                {
                    DatasetVector Dtv_Pick = layer.Dataset as DatasetVector;
                    if (Dtv_Pick.Type == DatasetType.Region)
                    {
                        num = 1;

                        //提取面边界
                        DatasetVector Dtv_result = PickUpBorder(Dtv_Pick);
                        if (Dtv_result != null)
                        {
                            LayerSettingVector layerSettingVector = new LayerSettingVector();
                            GeoStyle geoStyle = new GeoStyle();
                            geoStyle.LineColor = Color.Orange;
                            layerSettingVector.Style = geoStyle;

                            mapControl1.Map.Layers.Add(Dtv_result, layerSettingVector, true);
                            mapControl1.Map.Refresh();
                        }
                    }
                    break;
                }
                if (num != 1)
                {
                    MessageBox.Show("请打开面数据集！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:" + ex.Message + ex.StackTrace);
            }
        }

        private void 面拓扑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mapControl1.Map.Layers.Count != 0)
            {
                try
                {

                    if (workspace1.Datasources[layersControl1.Map.Layers[0].Dataset.Datasource.Alias].Datasets.Count != 0)
                    {
                        DobuleCheckTopo doublecheck = new DobuleCheckTopo(workspace1, mapControl1,layersControl1);
                        doublecheck.Show();
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("error:" + ex.Message + ex.StackTrace);
                }
            }
            else
            {
                MessageBox.Show("图层不能为空");
            }
        }

        private void workspaceControl1_WorkspaceTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            WorkspaceTreeNodeBase node = e.Node as WorkspaceTreeNodeBase;
            WorkspaceTreeNodeDataType type = node.NodeType;
            if ((type & WorkspaceTreeNodeDataType.Dataset) != WorkspaceTreeNodeDataType.Unknown)
            {
                type = WorkspaceTreeNodeDataType.Dataset;
            }
            switch (type)
            {
                case WorkspaceTreeNodeDataType.Dataset:
                    {
                        Dataset dataset = node.GetData() as Dataset;

                        if (this.layersControl1.Map != null)
                        {


                            if (layersControl1.Map.Layers.Contains(workspaceControl1.WorkspaceTree.SelectedNode.Name + "@" + workspaceControl1.WorkspaceTree.SelectedNode.Parent.Name))
                            {
                                return;
                            }

                            this.layersControl1.Map.Layers.Add(dataset, true);
                            this.mapControl1.Map.Refresh();
                        }
                        else if (this.layersControl1.Scene != null)
                        {
                            this.layersControl1.Scene.Layers.Add(dataset, (Theme3D)null, true);
                        }
                    }
                    break;
                case WorkspaceTreeNodeDataType.MapName:
                    {
                        String mapName = node.GetData() as String;

                        if (this.layersControl1.Map != null)
                        {
                            this.mapControl1.Map.Open(mapName);
                            this.mapControl1.Map.Refresh();
                        }
                        else if (this.layersControl1.Scene != null)
                        {
                            this.layersControl1.Scene.Layers.Add(mapName, Layer3DType.Map, true, mapName);
                        }
                    }
                    break;
                case WorkspaceTreeNodeDataType.SceneName:
                    {
                        String sceneName = node.GetData() as String;
                        if (this.layersControl1.Scene != null)
                        {
                            this.layersControl1.Scene.Open(sceneName);
                        }
                    }
                    break;
                default:
                    break;
            }

        }

        private void CreateBuffer_Button_Click(object sender, EventArgs e)
        {
            if (mapControl1.Map.Layers.Count > 0)
            {
                Selection[] selection = mapControl1.Map.FindSelection(false);
                Selection s1 = selection[0];
                if (s1.Count == 0)
                {
                    MessageBox.Show("请选中数据");
                }
                else
                {
                    BufferAnalysisForm bufferAnalysis_Form = new BufferAnalysisForm(workspace1, mapControl1, dataGridView1);
                    bufferAnalysis_Form.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("请添加图层");
            }
            

        }

        private void DesignMenuStrip_Opening(object sender, CancelEventArgs e)
        {

        }

        private void 符号设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ltn = this.layersControl1.LayersTree.SelectedNode as LayersTreeNodeBase;
            object ob = ltn.GetData();
            Layer layer = ob as Layer;
            DatasetType dt = layer.Dataset.Type;
            LayerSettingVector lsv = new LayerSettingVector();
            SymbolType symbolType = SymbolType.Marker;
            switch (dt)
            {
                case DatasetType.Point:
                    symbolType=SymbolType.Marker;
                    break;
                case DatasetType.Line:
                    symbolType = SymbolType.Line;
                    break;
                case DatasetType.Region:
                    symbolType = SymbolType.Fill;
                    break;
                    
            }

            GeoStyle geo = SymbolDialog.ShowDialog(workspace1.Resources, lsv.Style, symbolType);
            lsv.Style = geo;
            layer.AdditionalSetting = lsv;
            mapControl1.Map.Refresh();
        }

        private void 删除数据源ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int tmpi = 0;
            for (tmpi = 0; tmpi < workspace1.Datasources[workspaceControl1.WorkspaceTree.SelectedNode.Name].Datasets.Count; tmpi++)
            {
                layersControl1.Map.Layers.Remove(workspace1.Datasources[workspaceControl1.WorkspaceTree.SelectedNode.Name].Datasets[tmpi].Name + "@" + workspaceControl1.WorkspaceTree.SelectedNode.Name);
                Common.namesOfExistedDatasets.Remove(workspaceControl1.WorkspaceTree.SelectedNode.Name + "." + workspace1.Datasources[workspaceControl1.WorkspaceTree.SelectedNode.Name].Datasets[tmpi].Name);
            }
            layersControl1.Refresh();

                Common.namesOfOpenedDatasources.Remove(workspaceControl1.WorkspaceTree.SelectedNode.Name);



            workspace1.Datasources[workspaceControl1.WorkspaceTree.SelectedNode.Name].Close();
            mapControl1.Refresh();
        }

        private void 重命名数据源ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatasourceRenameForm DatasourceRename_Form = new DatasourceRenameForm(workspace1, workspaceControl1,layersControl1);
            if (DatasourceRename_Form.ShowDialog() == DialogResult.Yes)
            {
                MessageBox.Show("别名修改成功");
                int tmpi;
                for (tmpi = 0; tmpi < workspace1.Datasources[workspaceControl1.WorkspaceTree.SelectedNode.Name].Datasets.Count; tmpi++)
                {
                    layersControl1.Map.Layers.Add(workspace1.Datasources[workspaceControl1.WorkspaceTree.SelectedNode.Name].Datasets[tmpi], true);
                    Common.namesOfExistedDatasets.Add(workspace1.Datasources[workspaceControl1.WorkspaceTree.SelectedNode.Name].Alias + "." + workspace1.Datasources[workspaceControl1.WorkspaceTree.SelectedNode.Name].Datasets[tmpi].Name);
                }
                layersControl1.Refresh();
            }
            //workspace1.Datasources.ModifyAlias

        }

        private void 查看属性ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 属性查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Common.isInLayercontrol = true;
            DatasetVector dv = mapControl1.Map.Layers[layersControl1.LayersTree.SelectedNode.Name].Dataset as DatasetVector;
            Recordset recordset = dv.GetRecordset(false, CursorType.Static);

            this.dataGridView1.Columns.Clear();
            this.dataGridView1.Rows.Clear();

            for (int i = 0; i < recordset.FieldCount; i++)
            {
                //定义并获得字段名称
                String fieldName = recordset.GetFieldInfos()[i].Name;

                //将得到的字段名称添加到dataGridView列中
                this.dataGridView1.Columns.Add(fieldName, fieldName);
            }

            //初始化row
            DataGridViewRow row = null;

            //根据选中记录的个数，将选中对象的信息添加到dataGridView中显示
            while (!recordset.IsEOF)
            {
                row = new DataGridViewRow();
                for (int i = 0; i < recordset.FieldCount; i++)
                {
                    //定义并获得字段值
                    Object fieldValue = recordset.GetFieldValue(i);

                    //将字段值添加到dataGridView中对应的位置
                    DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                    if (fieldValue != null)
                    {
                        cell.ValueType = fieldValue.GetType();
                        cell.Value = fieldValue;
                    }

                    row.Cells.Add(cell);
                }

                this.dataGridView1.Rows.Add(row);

                recordset.MoveNext();
            }
            this.dataGridView1.Update();

            recordset.Dispose();
        }

        private void 新建面数据集ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (workspaceControl1.WorkspaceTree.SelectedNode != null)
            {
                WorkspaceTreeNodeBase node = workspaceControl1.WorkspaceTree.SelectedNode as WorkspaceTreeNodeBase;
                if (node.NodeType == WorkspaceTreeNodeDataType.Datasource)
                {
                    DatasetManage datasetManage = new DatasetManage(workspace1, mapControl1);
                    string tmpSelectedDatasourceName = workspaceControl1.WorkspaceTree.SelectedNode.Name;
                    DatasetName_Form.Init(workspaceControl1.WorkspaceTree.SelectedNode.Name);
                    DatasetName_Form.ShowDialog();
                    if (DatasetName_Form.DialogResult == DialogResult.Yes)
                    {
                        datasetManage.AddRegionDataset(tmpSelectedDatasourceName, layersControl1);
                        Common.namesOfExistedDatasets.Add(tmpSelectedDatasourceName + "." + Common.tmpDatasetName);
                    }
                }
                else
                {
                    MessageBox.Show("请选中数据源");
                }
            }
            else
            {
                MessageBox.Show("请选中节点");
            }
        }

        private void 编辑面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkspaceTreeNodeBase node = workspaceControl1.WorkspaceTree.SelectedNode as WorkspaceTreeNodeBase;
            Dataset tmpDs = node.GetData() as Dataset;
            if (node.NodeType == WorkspaceTreeNodeDataType.DatasetVector)
            {
                if (tmpDs.Type == DatasetType.Region)
                {
                    Layers layers = mapControl1.Map.Layers;
                    Layer layer = layers[workspaceControl1.WorkspaceTree.SelectedNode.Name + "@" + workspaceControl1.WorkspaceTree.SelectedNode.Parent.Name];
                    layer.IsEditable = true;
                    mapControl1.Action = SuperMap.UI.Action.CreatePolygon;
                    mapControl1.Refresh();
                    //EditDatasetMenuStrip.Items[4].Enabled = true;
                }
                else
                {
                    MessageBox.Show("请选择面数据集");
                }
            }
            else
            {
                MessageBox.Show("请选中数据集");
            }
        }

        private void 停止选择ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mapControl1.Map.Layers[0].IsEditable = true;
            mapControl1.Action = SuperMap.UI.Action.Select;
            mapControl1.Refresh();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (Common.isInLayercontrol)
            {
                if (e.RowIndex > -1)
                {
                    MessageBox.Show("选中行" + (e.RowIndex + 1));
                    Int32 layerCount = mapControl1.Map.Layers.Count;
                    //判断当前地图窗口中是否有打开的图层
                    if (layerCount == 0)
                    {
                        MessageBox.Show("请先打开一个矢量数据集！");
                        return;
                    }

                    //定义查询条件信息;
                    QueryParameter queryParameter = new QueryParameter();
                    string a = dataGridView1.Columns[0].HeaderText;
                    a = a + "=" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    queryParameter.AttributeFilter = a;
                    queryParameter.CursorType = CursorType.Static;

                    Boolean hasGeometry = false;
                    //遍历每一个图层，实现多图层查询
                    Layer layer = mapControl1.Map.Layers[layersControl1.LayersTree.SelectedNode.Name];
                    // 得到矢量数据集并强制转换为矢量数据集类型
                    DatasetVector dataset = layer.Dataset as DatasetVector;
                    // 通过查询条件对矢量数据集进行查询,从数据集中查询出属性数据，
                    Recordset recordset = dataset.Query(queryParameter);
                    // 判断是否有查询结果
                    if (recordset.RecordCount > 0)
                    {
                        hasGeometry = true;

                    }

                    mapControl1.Map.EnsureVisible(recordset);//居中
                    Selection selection = layer.Selection;
                    selection = layer.Selection;
                    selection.FromRecordset(recordset);
                    for (int i = 1; i < 4; i++)
                    {
                        selection.FromRecordset(recordset);
                        mapControl1.Map.Refresh();
                        Delay(500);
                        selection.Clear();
                        mapControl1.Map.Refresh();
                        Delay(500);
                    }
                    mapControl1.Map.Refresh();
                    Delay(500);
                    recordset.Dispose();




                    // 没有查询结果，弹出提示
                    if (!hasGeometry)
                    {
                        MessageBox.Show("没有符合查询条件的结果或查询条件有误，请重新确认后查询！");
                    }

                    //当可创建对象使用完毕后，使用Dispose方法来释放所占用的内部资源。
                    queryParameter.Dispose();

                    // 刷新地图窗口显示
                    mapControl1.Refresh();
                    hasGeometry = false;
                }
                else
                {
                    dataGridView1.ClearSelection();
                }
            }
        }
    }
}
