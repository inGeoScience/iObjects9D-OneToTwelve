using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMap.Data;

namespace One2Twelve
{
    class Common
    {
        public static string sfDialogFilename;
        public static string tmpDatasetName;
        public static bool createUdbSuccess = false;
        public static string tmpDatasourceName;
        public static string tmpFieldName;
        public static string tmpFieldType;
        public static string tmpFieldDeletingName;
        public static string tmpFieldRename;
        public static string tmpFieldBeRenamed;
        public static bool isNewEmptyWorkspace = true;
        public static string filePathOfTheWorkspace;
        public static List<string> namesOfOpenedDatasources = new List<string>();
        public static List<string> namesOfExistedDatasets = new List<string>();
        public static bool isInLayercontrol = false;
    }
}
