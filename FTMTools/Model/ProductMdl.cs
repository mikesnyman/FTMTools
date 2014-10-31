using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using FTMTools;

namespace FTMTools.Model
{
    public class ProductMdl 
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _path;
        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

        public bool IsChecked { get; set; }
        public ZipFileMdl SelectedZipFile { get; set; }

        public List<ZipFileMdl> ZipFiles
        {
            get;
            set;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// Fills ZipFileCollection with parameter path name
          public ProductMdl(string name, string path)
        {
            _name = name;
            _path = path;

            string[] versions = new string[100];
            versions = Directory.GetFiles(_path);
            ZipFiles = new List<ZipFileMdl>();
            foreach(var zip in versions)
            {
                if ((zip.Contains("English") || zip.Contains("Swedish") || zip.Contains("German")) && zip.Contains(".zip"))
                {
                    ZipFileMdl temp = new ZipFileMdl(zip);
                    ZipFiles.Add(temp);
                    CheckBox cb = new CheckBox();
                }
            }
        }       

    }
}
