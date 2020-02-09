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
    public class DatasetManage
    {
        public Workspace dp_workspace;
        private MapControl dp_mapControl;

        public DatasetManage(Workspace tmpWorkspace, MapControl tmp_mapControl)
        {
            dp_workspace = tmpWorkspace;
            dp_mapControl = tmp_mapControl;
            dp_mapControl.Map.Workspace = tmpWorkspace;
            this.Init();
        }

        private void Init()
        {
            dp_mapControl.Action = SuperMap.UI.Action.Pan;
            dp_mapControl.Map.ViewEntire();

            dp_mapControl.ActionChanged += new ActionChangedEventHandler(dp_mapControl_ActionChanged);
            dp_mapControl.Action = SuperMap.UI.Action.Select;
        }

        private void dp_mapControl_ActionChanged(object sender, ActionChangedEventArgs e)
        {
            if (e.NewAction == SuperMap.UI.Action.Select2)
            {
                dp_mapControl.Action = SuperMap.UI.Action.Select;
            }
        }

        public void AddPointDataset(string tmpdatasourcetName, LayersControl layersControl1, MapControl m_mapControl)
        {
            DatasetVectorInfo dsvInfo = new DatasetVectorInfo(Common.tmpDatasetName, DatasetType.Point);
            DatasetVector dataset = dp_workspace.Datasources[tmpdatasourcetName].Datasets.Create(dsvInfo);
            dp_mapControl.Map.Layers.Add(dataset, true);
            layersControl1.Map = dp_mapControl.Map;
        }

        public void AddLineDataset(string tmpdatasourcename, LayersControl layersControl1)
        {
            DatasetVectorInfo dsvInfo = new DatasetVectorInfo(Common.tmpDatasetName, DatasetType.Line);
            DatasetVector dataset = dp_workspace.Datasources[tmpdatasourcename].Datasets.Create(dsvInfo);

            
            dp_mapControl.Map.Layers.Add(dataset, true);
            layersControl1.Map = dp_mapControl.Map;
        }

        public void dataSourceSave()
        {
            //DatasourceConnectionInfo dsconnInfo = new DatasourceConnectionInfo();
            //dsconnInfo.Server = @Common.sfDialogFilename;
            //dsconnInfo.Alias = System.IO.Path.GetFileNameWithoutExtension(Common.sfDialogFilename);
            //dsconnInfo.EngineType = EngineType.UDB;
            //dp_datasource = dp_workspace.Datasources.Create(dsconnInfo);
            dp_workspace.Save();
        }

        public void AddRegionDataset(string tmpdatasourcename, LayersControl layersControl1)
        {
            DatasetVectorInfo dsvInfo = new DatasetVectorInfo(Common.tmpDatasetName, DatasetType.Region);
            DatasetVector dataset = dp_workspace.Datasources[tmpdatasourcename].Datasets.Create(dsvInfo);

            dp_mapControl.Map.Layers.Add(dataset, true);
            layersControl1.Map = dp_mapControl.Map;
        }
    }
}
