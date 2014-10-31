using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTMTools.Model
{
    public class ZipFileCollectionMdl 
    {
        private ObservableCollection<ZipFileMdl> _zipCollection = new ObservableCollection<ZipFileMdl>();
        public ObservableCollection<ZipFileMdl> ZipCollection
        {
            get { return _zipCollection; }
        }
        
        public void AddZip(ZipFileMdl zip)
        {
            ZipCollection.Add(zip);
        }
        public ZipFileMdl SelectedItem { get; set; }
    }
}
