using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FTMTools.Model;
using FTMTools.ViewModel;

namespace FTMTools
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {            
            InitializeComponent();
            //NamePathMasterCollectionMdl temp = new NamePathMasterCollectionMdl();
            //temp.GetPaths();
            //temp.SetPaths();
            //ObservableCollection<ProductMdl> _dc = new ObservableCollection<ProductMdl>;
            DataContext = new MasterListOfProductsVM();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {  
            MessageBox.Show("FTM Tools v1.0\n\n Developed for Ancestry.com by Michael Nyman\n\nSupported by Layne Farley\n lfarley@ancestry.com\n 801-705-7903\n\n");
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("FTM Tools was created to enable testing of the Family Tree Maker and all of its various verions.\n\nUse this tool to install previous release builds for past shipping producst, and a choice of the last 20 builds of current products under development.  Select the appropriate development environment(Dev, Stage, Live) which will ten modify the FTM files to allow proper running.\n\nUse this tool to display/modify your 'hosts' file directly.\n\nRun the 'Deep Clean' utility to erase both files and registry entries left around after basic uninstalls.\n\n=================================================\n\nFTM Tools was developed for Ancestry.com by Michael Nyman\n\nIf you have any problems or suggestions, please contact:\n\nMichael Nyman\nmnyman@ancestry.com\n801-705-????");
        }

        private void History_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("FTM Tools: Readme v1.00\n\n----------------------------------\n\nVersion History\n\nv1.00  Initial Release\n\nInstallation notes:\n\nThis is a standalone utility which includes all necessary file needed.  You can install 7-Zip files from within the tool.\n\n------------------------------\n\nContact information:\n\nMichael Nyman\nmnyman@ancestry.com\n801-705-????");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ChangePaths_Click(object sender, RoutedEventArgs e)
        {
            PathsWindow pathWin = new PathsWindow();
            pathWin.DataContext = this.DataContext;
            pathWin.Show();
        }


        private void Install_Click(object sender, RoutedEventArgs e)
        {
            
        }

    }
}
