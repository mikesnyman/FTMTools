using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using FTMTools.Model;

namespace FTMTools.ViewModel
{
    public class MasterListOfProductsVM : INotifyPropertyChanged
    {
        public static ObservableCollection<ProductMdl> Master = new ObservableCollection<ProductMdl>();
        public static NamePathMasterCollectionMdl VersionPath = new NamePathMasterCollectionMdl();
        
        public static ObservableCollection<ProductMdl> GetProducts()
        {           
            Dictionary<string, string> temp = new Dictionary<string, string>();
            temp = VersionPath.GetPaths();

            foreach(KeyValuePair<string, string> item in temp)
            {                
                ZipFileCollectionVM zfcl = new ZipFileCollectionVM();
                ProductMdl temps = new ProductMdl(item.Key, item.Value);
                Master.Add(temps);
            }
            return Master;
        }

        public static ObservableCollection<ProductMdl> Products
        {
            get { return GetProducts(); }
        }

        //public static void SetPaths()
        //{
        //    VersionPath.SetPaths();
        //}
        
       
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(
            [CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                    new PropertyChangedEventArgs(caller));
            }
        }

        public ICommand SaveChanges
        {
            get
            {
                return new DelegateCommand(o => Task.Run(() =>
                {
                    InstallMdl installmdl = new InstallMdl();
                    foreach (var item in Master)
                    {
                        if (item.IsChecked && item.SelectedZipFile != null)
                        {
                            installmdl.DirectoryVersion(item.SelectedZipFile.ZipFileVersion);
                        }
                    }
                }));
            }
        }
    }
}
