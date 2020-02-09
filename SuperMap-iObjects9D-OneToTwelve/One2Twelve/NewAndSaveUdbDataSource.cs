using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMap.Data;
using SuperMap.UI;
using SuperMap.Mapping;
using System.Drawing;
using System.Windows.Forms;

namespace One2Twelve
{
    public class NewAndSaveUdbDataSource
    {
        public Workspace udb_workspace;
        private MapControl udb_mapControl;
        private Datasource udb_datasource;

        public NewAndSaveUdbDataSource(Workspace workspace, MapControl mapControl)
        {
            udb_workspace = workspace;
            udb_mapControl = mapControl;
            udb_mapControl.Map.Workspace = workspace;
            Init();
        }

        public void InitForOpenWorkspace(Workspace workspace, MapControl mapControl)
        {
            udb_workspace = workspace;
            udb_mapControl = mapControl;
            udb_mapControl.Map.Workspace = workspace;
        }

        private void Init()
        {
            udb_mapControl.Action = SuperMap.UI.Action.Pan;
            udb_mapControl.Map.ViewEntire();

            udb_mapControl.ActionChanged += new ActionChangedEventHandler(udb_mapControl_ActionChanged);
            udb_mapControl.Action = SuperMap.UI.Action.Select;
            CreateUDBDatasource();

        }

        private void CreateUDBDatasource()
        {
            SaveFileDialog sfDialog = new SaveFileDialog();
            sfDialog.Filter = "SuperMap 文件型数据源(*.udb)|*.udb";
            sfDialog.OverwritePrompt = false;
            if (sfDialog.ShowDialog() == DialogResult.OK)
            {
                if (!System.IO.File.Exists(sfDialog.FileName))
                {
                    DatasourceConnectionInfo info = new DatasourceConnectionInfo();
                    info.Server = @sfDialog.FileName;
                    info.Alias = System.IO.Path.GetFileNameWithoutExtension(sfDialog.FileName);
                    info.EngineType = EngineType.UDB;
                    udb_datasource = udb_workspace.Datasources.Create(info);
                    Common.createUdbSuccess = true;
                    Common.namesOfOpenedDatasources.Add(System.IO.Path.GetFileNameWithoutExtension(sfDialog.FileName));
                }
                else
                {
                    MessageBox.Show("文件已存在");
                }
            }
            Common.sfDialogFilename = sfDialog.FileName;

        }

        private void udb_mapControl_ActionChanged(object sender, ActionChangedEventArgs e)
        {
            if (e.NewAction == SuperMap.UI.Action.Select2)
            {
                udb_mapControl.Action = SuperMap.UI.Action.Select;
            }
        }

    }
}
