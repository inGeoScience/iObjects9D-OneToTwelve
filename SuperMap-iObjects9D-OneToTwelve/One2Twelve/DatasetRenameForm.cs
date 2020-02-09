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
using SuperMap.UI;

namespace One2Twelve
{
    public partial class DatasetRenameForm : Form
    {

        private WorkspaceControl renameWorkspaceControl;
        private Workspace renameWorkspace;
        private LayersControl renameLayerscontrol;

        public DatasetRenameForm()
        {
            InitializeComponent();
        }

        public DatasetRenameForm(Workspace wkspace, WorkspaceControl wkspaceControl,LayersControl lyC)
        {
            renameWorkspace = wkspace;
            renameWorkspaceControl = wkspaceControl;
            renameLayerscontrol = lyC;
            InitializeComponent();
            RenameconFirm_button.Enabled = false;
        }

        private void RenameconFirm_button_Click(object sender, EventArgs e)
        {
            renameLayerscontrol.Map.Layers.Remove(renameWorkspaceControl.WorkspaceTree.SelectedNode.Name + "@" + renameWorkspaceControl.WorkspaceTree.SelectedNode.Parent.Name);
            Common.namesOfExistedDatasets.Remove(renameWorkspaceControl.WorkspaceTree.SelectedNode.Name);
            renameWorkspace.Datasources[renameWorkspaceControl.WorkspaceTree.SelectedNode.Parent.Name].Datasets.Rename(renameWorkspaceControl.WorkspaceTree.SelectedNode.Name, RenameDataset_Textbox.Text);
            Common.namesOfExistedDatasets.Add(renameWorkspaceControl.WorkspaceTree.SelectedNode.Parent.Name+"."+RenameDataset_Textbox.Text);
            
        }

        private void RenameDataset_Textbox_TextChanged(object sender, EventArgs e)
        {
            if (RenameDataset_Textbox.Text != "" && !Common.namesOfExistedDatasets.Contains(renameWorkspaceControl.WorkspaceTree.SelectedNode.Parent.Name + "." + RenameDataset_Textbox.Text))
            {
                RenameconFirm_button.Enabled = true;
            }
            else
            {
                RenameconFirm_button.Enabled = false;
            }
        }
    }
}
