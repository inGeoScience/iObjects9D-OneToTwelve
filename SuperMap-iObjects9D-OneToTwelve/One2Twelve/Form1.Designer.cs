namespace One2Twelve
{
    partial class One2Twelve
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(One2Twelve));
            this.mapControl1 = new SuperMap.UI.MapControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.workspaceControl1 = new SuperMap.UI.WorkspaceControl();
            this.layersControl1 = new SuperMap.UI.LayersControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.workspace1 = new SuperMap.Data.Workspace(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.selectAttributes_button = new System.Windows.Forms.ToolStripButton();
            this.CreateBuffer_Button = new System.Windows.Forms.ToolStripButton();
            this.GetAttribute_Button = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.拓扑检查ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.提取面边界ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.面拓扑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DatasourcesMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新建数据源ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.打开数据源ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workspaceMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新建文件型工作空间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开文件型工作空间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭工作空间ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.保存文件型工作空间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存文件型工作空间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditDatasetMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.编辑点ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑线ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选择ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.重命名数据集ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.删除数据集ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.新建字段ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.删除字段ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.重命名字段ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.停止选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DatasourceMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新建点数据集ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.新建线数据集ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.新建面数据集ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存数据ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.导入shpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除数据源ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重命名数据源ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DesignMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.符号设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.属性查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.DatasourcesMenuStrip.SuspendLayout();
            this.workspaceMenuStrip.SuspendLayout();
            this.EditDatasetMenuStrip.SuspendLayout();
            this.DatasourceMenuStrip.SuspendLayout();
            this.DesignMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapControl1
            // 
            this.mapControl1.Action = SuperMap.UI.Action.Select2;
            this.mapControl1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mapControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mapControl1.Location = new System.Drawing.Point(461, 38);
            this.mapControl1.Margin = new System.Windows.Forms.Padding(60, 28, 60, 28);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(866, 562);
            this.mapControl1.TabIndex = 2;
            this.mapControl1.TrackMode = SuperMap.UI.TrackMode.Edit;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(461, 604);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(867, 152);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // workspaceControl1
            // 
            this.workspaceControl1.AllowDefaultAction = true;
            this.workspaceControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.workspaceControl1.Location = new System.Drawing.Point(-4, 3);
            this.workspaceControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.workspaceControl1.Name = "workspaceControl1";
            this.workspaceControl1.Size = new System.Drawing.Size(460, 370);
            this.workspaceControl1.TabIndex = 4;
            // 
            // 
            // 
            this.workspaceControl1.WorkspaceToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.workspaceControl1.WorkspaceToolBar.Location = new System.Drawing.Point(0, 0);
            this.workspaceControl1.WorkspaceToolBar.Name = "WorkspaceToolBar";
            this.workspaceControl1.WorkspaceToolBar.Size = new System.Drawing.Size(460, 25);
            this.workspaceControl1.WorkspaceToolBar.TabIndex = 0;
            // 
            // 
            // 
            this.workspaceControl1.WorkspaceTree.AllowDrop = true;
            this.workspaceControl1.WorkspaceTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.workspaceControl1.WorkspaceTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.workspaceControl1.WorkspaceTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workspaceControl1.WorkspaceTree.ItemHeight = 17;
            this.workspaceControl1.WorkspaceTree.Location = new System.Drawing.Point(0, 52);
            this.workspaceControl1.WorkspaceTree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.workspaceControl1.WorkspaceTree.Name = "WorkspaceTree";
            this.workspaceControl1.WorkspaceTree.SelectedNodes = new System.Windows.Forms.TreeNode[0];
            this.workspaceControl1.WorkspaceTree.Size = new System.Drawing.Size(460, 318);
            this.workspaceControl1.WorkspaceTree.TabIndex = 1;
            this.workspaceControl1.WorkspaceTree.Workspace = null;
            this.workspaceControl1.WorkspaceTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.workspaceControl1_WorkspaceTree_NodeMouseDoubleClick);
            this.workspaceControl1.Load += new System.EventHandler(this.workspaceControl1_Load);
            // 
            // layersControl1
            // 
            this.layersControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.layersControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.layersControl1.Location = new System.Drawing.Point(-4, 378);
            this.layersControl1.Map = null;
            this.layersControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layersControl1.Name = "layersControl1";
            this.layersControl1.Scene = null;
            this.layersControl1.Size = new System.Drawing.Size(461, 347);
            this.layersControl1.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(-4, 728);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(463, 29);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(99, 24);
            this.toolStripStatusLabel1.Text = "憨憨憨憨憨憨";
            // 
            // workspace1
            // 
            this.workspace1.Caption = "UntitledWorkspace";
            this.workspace1.Description = "";
            this.workspace1.DesktopInfo = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAttributes_button,
            this.CreateBuffer_Button,
            this.GetAttribute_Button,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(477, 9);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(316, 27);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // selectAttributes_button
            // 
            this.selectAttributes_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.selectAttributes_button.Image = ((System.Drawing.Image)(resources.GetObject("selectAttributes_button.Image")));
            this.selectAttributes_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectAttributes_button.Name = "selectAttributes_button";
            this.selectAttributes_button.Size = new System.Drawing.Size(60, 24);
            this.selectAttributes_button.Text = "查询器";
            this.selectAttributes_button.Click += new System.EventHandler(this.selectAttributes_button_Click);
            // 
            // CreateBuffer_Button
            // 
            this.CreateBuffer_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CreateBuffer_Button.Image = ((System.Drawing.Image)(resources.GetObject("CreateBuffer_Button.Image")));
            this.CreateBuffer_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CreateBuffer_Button.Name = "CreateBuffer_Button";
            this.CreateBuffer_Button.Size = new System.Drawing.Size(89, 24);
            this.CreateBuffer_Button.Text = "缓冲区分析";
            this.CreateBuffer_Button.Click += new System.EventHandler(this.CreateBuffer_Button_Click);
            // 
            // GetAttribute_Button
            // 
            this.GetAttribute_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.GetAttribute_Button.Image = ((System.Drawing.Image)(resources.GetObject("GetAttribute_Button.Image")));
            this.GetAttribute_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GetAttribute_Button.Name = "GetAttribute_Button";
            this.GetAttribute_Button.Size = new System.Drawing.Size(73, 24);
            this.GetAttribute_Button.Text = "要素属性";
            this.GetAttribute_Button.Click += new System.EventHandler(this.GetAttribute_Button_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.拓扑检查ToolStripMenuItem,
            this.提取面边界ToolStripMenuItem,
            this.面拓扑ToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(82, 24);
            this.toolStripDropDownButton1.Text = "拓扑分析";
            // 
            // 拓扑检查ToolStripMenuItem
            // 
            this.拓扑检查ToolStripMenuItem.Name = "拓扑检查ToolStripMenuItem";
            this.拓扑检查ToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.拓扑检查ToolStripMenuItem.Text = "拓扑检查";
            this.拓扑检查ToolStripMenuItem.Click += new System.EventHandler(this.拓扑检查ToolStripMenuItem_Click);
            // 
            // 提取面边界ToolStripMenuItem
            // 
            this.提取面边界ToolStripMenuItem.Name = "提取面边界ToolStripMenuItem";
            this.提取面边界ToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.提取面边界ToolStripMenuItem.Text = "提取面边界";
            this.提取面边界ToolStripMenuItem.Click += new System.EventHandler(this.提取面边界ToolStripMenuItem_Click);
            // 
            // 面拓扑ToolStripMenuItem
            // 
            this.面拓扑ToolStripMenuItem.Name = "面拓扑ToolStripMenuItem";
            this.面拓扑ToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.面拓扑ToolStripMenuItem.Text = "面拓扑";
            this.面拓扑ToolStripMenuItem.Click += new System.EventHandler(this.面拓扑ToolStripMenuItem_Click);
            // 
            // DatasourcesMenuStrip
            // 
            this.DatasourcesMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建数据源ToolStripMenuItem1,
            this.打开数据源ToolStripMenuItem});
            this.DatasourcesMenuStrip.Name = "contextMenuStrip1";
            this.DatasourcesMenuStrip.Size = new System.Drawing.Size(154, 52);
            // 
            // 新建数据源ToolStripMenuItem1
            // 
            this.新建数据源ToolStripMenuItem1.Name = "新建数据源ToolStripMenuItem1";
            this.新建数据源ToolStripMenuItem1.Size = new System.Drawing.Size(153, 24);
            this.新建数据源ToolStripMenuItem1.Text = "新建数据源";
            this.新建数据源ToolStripMenuItem1.Click += new System.EventHandler(this.新建数据源ToolStripMenuItem1_Click);
            // 
            // 打开数据源ToolStripMenuItem
            // 
            this.打开数据源ToolStripMenuItem.Name = "打开数据源ToolStripMenuItem";
            this.打开数据源ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.打开数据源ToolStripMenuItem.Text = "打开数据源";
            this.打开数据源ToolStripMenuItem.Click += new System.EventHandler(this.打开数据源ToolStripMenuItem_Click);
            // 
            // workspaceMenuStrip
            // 
            this.workspaceMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建文件型工作空间ToolStripMenuItem,
            this.打开文件型工作空间ToolStripMenuItem,
            this.关闭工作空间ToolStripMenuItem1,
            this.保存文件型工作空间ToolStripMenuItem,
            this.另存文件型工作空间ToolStripMenuItem});
            this.workspaceMenuStrip.Name = "workspaceMenuStrip";
            this.workspaceMenuStrip.Size = new System.Drawing.Size(215, 124);
            // 
            // 新建文件型工作空间ToolStripMenuItem
            // 
            this.新建文件型工作空间ToolStripMenuItem.Name = "新建文件型工作空间ToolStripMenuItem";
            this.新建文件型工作空间ToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.新建文件型工作空间ToolStripMenuItem.Text = "新建文件型工作空间";
            this.新建文件型工作空间ToolStripMenuItem.Click += new System.EventHandler(this.新建文件型工作空间ToolStripMenuItem_Click);
            // 
            // 打开文件型工作空间ToolStripMenuItem
            // 
            this.打开文件型工作空间ToolStripMenuItem.Name = "打开文件型工作空间ToolStripMenuItem";
            this.打开文件型工作空间ToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.打开文件型工作空间ToolStripMenuItem.Text = "打开文件型工作空间";
            this.打开文件型工作空间ToolStripMenuItem.Click += new System.EventHandler(this.打开文件型工作空间ToolStripMenuItem_Click);
            // 
            // 关闭工作空间ToolStripMenuItem1
            // 
            this.关闭工作空间ToolStripMenuItem1.Name = "关闭工作空间ToolStripMenuItem1";
            this.关闭工作空间ToolStripMenuItem1.Size = new System.Drawing.Size(214, 24);
            this.关闭工作空间ToolStripMenuItem1.Text = "关闭工作空间";
            this.关闭工作空间ToolStripMenuItem1.Click += new System.EventHandler(this.关闭工作空间ToolStripMenuItem1_Click);
            // 
            // 保存文件型工作空间ToolStripMenuItem
            // 
            this.保存文件型工作空间ToolStripMenuItem.Name = "保存文件型工作空间ToolStripMenuItem";
            this.保存文件型工作空间ToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.保存文件型工作空间ToolStripMenuItem.Text = "保存工作空间";
            this.保存文件型工作空间ToolStripMenuItem.Click += new System.EventHandler(this.保存文件型工作空间ToolStripMenuItem_Click);
            // 
            // 另存文件型工作空间ToolStripMenuItem
            // 
            this.另存文件型工作空间ToolStripMenuItem.Name = "另存文件型工作空间ToolStripMenuItem";
            this.另存文件型工作空间ToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.另存文件型工作空间ToolStripMenuItem.Text = "另存文件型工作空间";
            this.另存文件型工作空间ToolStripMenuItem.Click += new System.EventHandler(this.另存文件型工作空间ToolStripMenuItem_Click);
            // 
            // EditDatasetMenuStrip
            // 
            this.EditDatasetMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑点ToolStripMenuItem1,
            this.编辑线ToolStripMenuItem1,
            this.编辑面ToolStripMenuItem,
            this.选择ToolStripMenuItem1,
            this.重命名数据集ToolStripMenuItem1,
            this.删除数据集ToolStripMenuItem1,
            this.新建字段ToolStripMenuItem1,
            this.删除字段ToolStripMenuItem1,
            this.重命名字段ToolStripMenuItem1,
            this.导出ToolStripMenuItem,
            this.停止选择ToolStripMenuItem});
            this.EditDatasetMenuStrip.Name = "EditDatasetMenuStrip";
            this.EditDatasetMenuStrip.Size = new System.Drawing.Size(185, 268);
            // 
            // 编辑点ToolStripMenuItem1
            // 
            this.编辑点ToolStripMenuItem1.Name = "编辑点ToolStripMenuItem1";
            this.编辑点ToolStripMenuItem1.Size = new System.Drawing.Size(184, 24);
            this.编辑点ToolStripMenuItem1.Text = "编辑点";
            this.编辑点ToolStripMenuItem1.Click += new System.EventHandler(this.编辑点ToolStripMenuItem1_Click);
            // 
            // 编辑线ToolStripMenuItem1
            // 
            this.编辑线ToolStripMenuItem1.Name = "编辑线ToolStripMenuItem1";
            this.编辑线ToolStripMenuItem1.Size = new System.Drawing.Size(184, 24);
            this.编辑线ToolStripMenuItem1.Text = "编辑线";
            this.编辑线ToolStripMenuItem1.Click += new System.EventHandler(this.编辑线ToolStripMenuItem1_Click);
            // 
            // 编辑面ToolStripMenuItem
            // 
            this.编辑面ToolStripMenuItem.Name = "编辑面ToolStripMenuItem";
            this.编辑面ToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.编辑面ToolStripMenuItem.Text = "编辑面";
            this.编辑面ToolStripMenuItem.Click += new System.EventHandler(this.编辑面ToolStripMenuItem_Click);
            // 
            // 选择ToolStripMenuItem1
            // 
            this.选择ToolStripMenuItem1.Name = "选择ToolStripMenuItem1";
            this.选择ToolStripMenuItem1.Size = new System.Drawing.Size(184, 24);
            this.选择ToolStripMenuItem1.Text = "选择";
            this.选择ToolStripMenuItem1.Click += new System.EventHandler(this.选择ToolStripMenuItem1_Click);
            // 
            // 重命名数据集ToolStripMenuItem1
            // 
            this.重命名数据集ToolStripMenuItem1.Name = "重命名数据集ToolStripMenuItem1";
            this.重命名数据集ToolStripMenuItem1.Size = new System.Drawing.Size(184, 24);
            this.重命名数据集ToolStripMenuItem1.Text = "重命名数据集";
            this.重命名数据集ToolStripMenuItem1.Click += new System.EventHandler(this.重命名数据集ToolStripMenuItem1_Click);
            // 
            // 删除数据集ToolStripMenuItem1
            // 
            this.删除数据集ToolStripMenuItem1.Name = "删除数据集ToolStripMenuItem1";
            this.删除数据集ToolStripMenuItem1.Size = new System.Drawing.Size(184, 24);
            this.删除数据集ToolStripMenuItem1.Text = "删除数据集";
            this.删除数据集ToolStripMenuItem1.Click += new System.EventHandler(this.删除数据集ToolStripMenuItem1_Click);
            // 
            // 新建字段ToolStripMenuItem1
            // 
            this.新建字段ToolStripMenuItem1.Name = "新建字段ToolStripMenuItem1";
            this.新建字段ToolStripMenuItem1.Size = new System.Drawing.Size(184, 24);
            this.新建字段ToolStripMenuItem1.Text = "新建字段";
            this.新建字段ToolStripMenuItem1.Click += new System.EventHandler(this.新建字段ToolStripMenuItem1_Click);
            // 
            // 删除字段ToolStripMenuItem1
            // 
            this.删除字段ToolStripMenuItem1.Name = "删除字段ToolStripMenuItem1";
            this.删除字段ToolStripMenuItem1.Size = new System.Drawing.Size(184, 24);
            this.删除字段ToolStripMenuItem1.Text = "删除字段";
            this.删除字段ToolStripMenuItem1.Click += new System.EventHandler(this.删除字段ToolStripMenuItem1_Click);
            // 
            // 重命名字段ToolStripMenuItem1
            // 
            this.重命名字段ToolStripMenuItem1.Name = "重命名字段ToolStripMenuItem1";
            this.重命名字段ToolStripMenuItem1.Size = new System.Drawing.Size(184, 24);
            this.重命名字段ToolStripMenuItem1.Text = "重命名字段别名";
            this.重命名字段ToolStripMenuItem1.Click += new System.EventHandler(this.重命名字段ToolStripMenuItem1_Click);
            // 
            // 导出ToolStripMenuItem
            // 
            this.导出ToolStripMenuItem.Name = "导出ToolStripMenuItem";
            this.导出ToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.导出ToolStripMenuItem.Text = "导出shp";
            this.导出ToolStripMenuItem.Click += new System.EventHandler(this.导出ToolStripMenuItem_Click);
            // 
            // 停止选择ToolStripMenuItem
            // 
            this.停止选择ToolStripMenuItem.Name = "停止选择ToolStripMenuItem";
            this.停止选择ToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.停止选择ToolStripMenuItem.Text = "停止选择";
            this.停止选择ToolStripMenuItem.Click += new System.EventHandler(this.停止选择ToolStripMenuItem_Click);
            // 
            // DatasourceMenuStrip
            // 
            this.DatasourceMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建点数据集ToolStripMenuItem1,
            this.新建线数据集ToolStripMenuItem1,
            this.新建面数据集ToolStripMenuItem,
            this.保存数据ToolStripMenuItem1,
            this.导入shpToolStripMenuItem,
            this.删除数据源ToolStripMenuItem,
            this.重命名数据源ToolStripMenuItem});
            this.DatasourceMenuStrip.Name = "DatasourceMenuStrip";
            this.DatasourceMenuStrip.Size = new System.Drawing.Size(170, 172);
            // 
            // 新建点数据集ToolStripMenuItem1
            // 
            this.新建点数据集ToolStripMenuItem1.Name = "新建点数据集ToolStripMenuItem1";
            this.新建点数据集ToolStripMenuItem1.Size = new System.Drawing.Size(169, 24);
            this.新建点数据集ToolStripMenuItem1.Text = "新建点数据集";
            this.新建点数据集ToolStripMenuItem1.Click += new System.EventHandler(this.新建点数据集ToolStripMenuItem1_Click);
            // 
            // 新建线数据集ToolStripMenuItem1
            // 
            this.新建线数据集ToolStripMenuItem1.Name = "新建线数据集ToolStripMenuItem1";
            this.新建线数据集ToolStripMenuItem1.Size = new System.Drawing.Size(169, 24);
            this.新建线数据集ToolStripMenuItem1.Text = "新建线数据集";
            this.新建线数据集ToolStripMenuItem1.Click += new System.EventHandler(this.新建线数据集ToolStripMenuItem1_Click);
            // 
            // 新建面数据集ToolStripMenuItem
            // 
            this.新建面数据集ToolStripMenuItem.Name = "新建面数据集ToolStripMenuItem";
            this.新建面数据集ToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.新建面数据集ToolStripMenuItem.Text = "新建面数据集";
            this.新建面数据集ToolStripMenuItem.Click += new System.EventHandler(this.新建面数据集ToolStripMenuItem_Click);
            // 
            // 保存数据ToolStripMenuItem1
            // 
            this.保存数据ToolStripMenuItem1.Name = "保存数据ToolStripMenuItem1";
            this.保存数据ToolStripMenuItem1.Size = new System.Drawing.Size(169, 24);
            this.保存数据ToolStripMenuItem1.Text = "保存数据";
            this.保存数据ToolStripMenuItem1.Click += new System.EventHandler(this.保存数据ToolStripMenuItem1_Click);
            // 
            // 导入shpToolStripMenuItem
            // 
            this.导入shpToolStripMenuItem.Name = "导入shpToolStripMenuItem";
            this.导入shpToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.导入shpToolStripMenuItem.Text = "导入shp";
            this.导入shpToolStripMenuItem.Click += new System.EventHandler(this.导入shpToolStripMenuItem_Click);
            // 
            // 删除数据源ToolStripMenuItem
            // 
            this.删除数据源ToolStripMenuItem.Name = "删除数据源ToolStripMenuItem";
            this.删除数据源ToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.删除数据源ToolStripMenuItem.Text = "删除数据源";
            this.删除数据源ToolStripMenuItem.Click += new System.EventHandler(this.删除数据源ToolStripMenuItem_Click);
            // 
            // 重命名数据源ToolStripMenuItem
            // 
            this.重命名数据源ToolStripMenuItem.Name = "重命名数据源ToolStripMenuItem";
            this.重命名数据源ToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.重命名数据源ToolStripMenuItem.Text = "重命名数据源";
            this.重命名数据源ToolStripMenuItem.Click += new System.EventHandler(this.重命名数据源ToolStripMenuItem_Click);
            // 
            // DesignMenuStrip
            // 
            this.DesignMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.符号设置ToolStripMenuItem,
            this.属性查询ToolStripMenuItem});
            this.DesignMenuStrip.Name = "DesignMenuStrip";
            this.DesignMenuStrip.Size = new System.Drawing.Size(141, 52);
            this.DesignMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.DesignMenuStrip_Opening);
            // 
            // 符号设置ToolStripMenuItem
            // 
            this.符号设置ToolStripMenuItem.Name = "符号设置ToolStripMenuItem";
            this.符号设置ToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.符号设置ToolStripMenuItem.Text = "符号设置";
            this.符号设置ToolStripMenuItem.Click += new System.EventHandler(this.符号设置ToolStripMenuItem_Click);
            // 
            // 属性查询ToolStripMenuItem
            // 
            this.属性查询ToolStripMenuItem.Name = "属性查询ToolStripMenuItem";
            this.属性查询ToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.属性查询ToolStripMenuItem.Text = "属性查询";
            this.属性查询ToolStripMenuItem.Click += new System.EventHandler(this.属性查询ToolStripMenuItem_Click);
            // 
            // One2Twelve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 756);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.layersControl1);
            this.Controls.Add(this.workspaceControl1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mapControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "One2Twelve";
            this.Text = "憨八嘎";
            this.Load += new System.EventHandler(this.One2Twelve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.DatasourcesMenuStrip.ResumeLayout(false);
            this.workspaceMenuStrip.ResumeLayout(false);
            this.EditDatasetMenuStrip.ResumeLayout(false);
            this.DatasourceMenuStrip.ResumeLayout(false);
            this.DesignMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SuperMap.UI.MapControl mapControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SuperMap.UI.WorkspaceControl workspaceControl1;
        private SuperMap.UI.LayersControl layersControl1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private SuperMap.Data.Workspace workspace1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton selectAttributes_button;
        private System.Windows.Forms.ContextMenuStrip DatasourcesMenuStrip;
        private System.Windows.Forms.ContextMenuStrip workspaceMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 新建文件型工作空间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开文件型工作空间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存文件型工作空间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存文件型工作空间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭工作空间ToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip EditDatasetMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 编辑点ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 编辑线ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 选择ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 新建数据源ToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip DatasourceMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 新建点数据集ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 新建线数据集ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 保存数据ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 新建字段ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 删除字段ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 重命名字段ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 重命名数据集ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 删除数据集ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 导出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开数据源ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入shpToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton CreateBuffer_Button;
        private System.Windows.Forms.ToolStripButton GetAttribute_Button;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem 拓扑检查ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 提取面边界ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 面拓扑ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip DesignMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 符号设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除数据源ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重命名数据源ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 属性查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建面数据集ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 停止选择ToolStripMenuItem;
    }
}

