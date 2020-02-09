using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMap.Data;
using SuperMap.UI;
using SuperMap.Layout;
using SuperMap.Mapping;
using SuperMap.Data.Topology;
using System.Windows.Forms;

namespace One2Twelve
{
    public class Class1
    {
          private Workspace workspace_run;
        private MapControl mapcontrol_run;
        private DatasetVector[] DtvsSource;
        private DatasetVector Sour_Dtv;
        public  DatasetVector Dtv_ana;
        public  DatasetVector Dtv_re;
        private LayersControl layerscontrol_run;
         

        public Class1(Workspace workspace,MapControl mapControl,LayersControl layerscon)
        {
            workspace_run = workspace;
            mapcontrol_run = mapControl;
            layerscontrol_run = layerscon;
        }



        /// <summary>
        /// 面内拓扑预处理
        /// </summary>
        /// <param name="dtv"></param>
        /// <returns></returns>
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


        /// <summary>
        /// 进行面内拓扑检查
        /// </summary>
        /// <returns></returns>
        public DatasetVector IsValidate()
        {
            //设置输出数据源
            Datasource outputDts = workspace_run.Datasources[0];

            //获取拓扑错误数据集名
            if (outputDts.Datasets.Contains("TopoError"))
            {
                layerscontrol_run.Map.Layers.Remove("TopoError" + "@" + mapcontrol_run.Map.Layers[0].Dataset.Datasource.Alias);
                workspace_run.Datasources[0].Datasets.Delete("TopoError");
            } 
            //进行拓扑检查
            DatasetVector datasetVector = TopologyValidator.Validate(Sour_Dtv, Sour_Dtv, TopologyRule.LineNoDangles,0.1, null, outputDts,
                                       "TopoError");
            return datasetVector;
        }



        /// <summary>
        /// 进行拓扑处理
        /// </summary>
        /// <returns></returns>
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


        /// <summary>
        /// 提取面边界
        /// </summary>
        /// <param name="Dtv_PickUpBorder"></param>
        /// <returns></returns>
       public DatasetVector PickUpBorder(DatasetVector Dtv_PickUpBorder)
        {
            Datasource Dts = Dtv_PickUpBorder.Datasource;

            if (Dts.Datasets.Contains("RegionBorder"))
            {
                Dts.Datasets.Delete("RegionBorder");
            }
            DatasetVector Dtv_result = TopologyProcessing.PickupBorder(Dtv_PickUpBorder, Dts, "RegionBorder", true);

            return Dtv_result;
        }    
        


        /// <summary>
        /// 进行面面拓扑预处理
        /// </summary>
        /// <param name="Dtvs"></param>
        /// <returns></returns>
        public DatasetVector[] Ispropress_Dou(DatasetVector[] Dtvs)
        {
            //设置精度数组
            int[] Accuracys = new int[] { 2, 1 };

            //设置分析容限
            double Tol = Dtvs[0].Tolerance.Fuzzy;

            bool result = TopologyValidator.Preprocess(Dtvs, Accuracys, Tol);

            if (result)
            {
                return Dtvs;
            }
            else
            {
                Dtvs[0] = null;
                Dtvs[1] = null;
                return Dtvs;
            }
        }


        
        /// <summary>
        /// 进行面面拓扑分析
        /// </summary>
        /// <param name="Dtvs"></param>
        /// <returns></returns>
        public DatasetVector IsValidate_Dou(DatasetVector[] Dtvs)
       {
           //设置拓扑与处理面
            DatasetVector Dtv_1 = Dtvs[0];
            DatasetVector Dtv_2 = Dtvs[1];

            //确保生成的数据集无重名
            if (workspace_run.Datasources[0].Datasets.Contains("TopoError_Dou"))
            {
                layerscontrol_run.Map.Layers.Remove("TopoError_Dou" + "@" + mapcontrol_run.Map.Layers[0].Dataset.Datasource.Alias);
                workspace_run.Datasources[0].Datasets.Delete("TopoError_Dou");
            }

            DatasetVector Dtv_result = TopologyValidator.Validate(Dtv_1, Dtv_2, TopologyRule.RegionNoOverlapWith,0.1,null, workspace_run.Datasources[0], "TopoError_Dou");
            return Dtv_result;
       }
    }
}
