using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTMTools.Model
{
    public class VersionNameMdl
    {
        private string _versionName;
        public string VersionName { get; set; }

        public VersionNameMdl(string version)
        {
            this._versionName = version;
        }
    }
}
