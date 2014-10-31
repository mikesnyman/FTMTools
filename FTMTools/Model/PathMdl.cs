using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FTMTools.Model
{
    public class PathMdl
    {
        private string _path;
        public string APath { get; set; }

        public PathMdl() { }

        public PathMdl(string path)
        {
            //if (path.Contains("/") | path.Contains("\""))
            //{
            //    this._path = path;
            //}
            //else
            //{
            //    MessageBox.Show("Invalid Path format");
            //}
        }
    }
}
