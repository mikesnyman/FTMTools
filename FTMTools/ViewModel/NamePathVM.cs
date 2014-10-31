using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTMTools.ViewModel
{
    public class NamePathVM
    {
        public static NamePathMasterCollectionMdl namepaths = new NamePathMasterCollectionMdl();

        public static Dictionary<string,string> GetPaths()
        {
            return namepaths.GetPaths();
        }

        
    }
}
