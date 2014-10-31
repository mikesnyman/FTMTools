using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FTMTools.Model
{
    public class ZipFileMdl 
    {
        private string _zipFileVersion;
        public string ZipFileVersion
        {
            get { return _zipFileVersion; }
            set { _zipFileVersion = value; }
        }
        
        /// <summary>
        /// Constructor
        /// </summary>
        public ZipFileMdl(string zip)
        {
            this._zipFileVersion = zip;
        }
    }
}
