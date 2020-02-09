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

namespace One2Twelve
{
    public partial class DatasourceRenameForm : Form
    {

        private WorkspaceControl renameWorkspaceControl;
        private Workspace renameWorkspace;
        private LayersControl renameLaterscontrol;

        public DatasourceRenameForm(Workspace wkspace, WorkspaceControl wkspaceControl,LayersControl lyC)
        {
            InitializeComponent();
            renameWorkspace = wkspace;
            renameWorkspaceControl = wkspaceControl;
            renameLaterscontrol = lyC;
        }

        private void RenameDatasource_Textbox_TextChanged(object sender, EventArgs e)
        {
            if (RenameDatasource_Textbox.Text != "" && !Common.namesOfOpenedDatasources.Contains(RenameDatasource_Textbox.Text))
            {
                RenameconFirm_button.Enabled = true;
            }
            else
            {
                RenameconFirm_button.Enabled = false;
            }
        }

        public void Init(Workspace wkspace, WorkspaceControl wkspaceControl)
        {
            renameWorkspace = wkspace;
            renameWorkspaceControl = wkspaceControl;
        }

        private void RenameconFirm_button_Click(object sender, EventArgs e)
        {
            int tmpi;
            for (tmpi = 0; tmpi < renameWorkspace.Datasources[renameWorkspaceControl.WorkspaceTree.SelectedNode.Name].Datasets.Count; tmpi++)
            {
                if (renameLaterscontrol.Map.Layers.Contains(renameWorkspace.Datasources[renameWorkspaceControl.WorkspaceTree.SelectedNode.Name].Datasets[tmpi].Name + "@" + renameWorkspaceControl.WorkspaceTree.SelectedNode.Name))
                {
                    renameLaterscontrol.Map.Layers.Remove(renameWorkspace.Datasources[renameWorkspaceControl.WorkspaceTree.SelectedNode.Name].Datasets[tmpi].Name + "@" + renameWorkspaceControl.WorkspaceTree.SelectedNode.Name);
                }
            }
            renameLaterscontrol.Refresh();
                Common.namesOfOpenedDatasources.Remove(renameWorkspaceControl.WorkspaceTree.SelectedNode.Name);
            renameWorkspace.Datasources.ModifyAlias(renameWorkspaceControl.WorkspaceTree.SelectedNode.Name, RenameDatasource_Textbox.Text);
            Common.namesOfOpenedDatasources.Add(RenameDatasource_Textbox.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
