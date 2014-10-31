//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using FTMTools.Model;

//namespace FTMTools
//{
//    public static class MasterListOfProducts
//    {
//        public static ObservableCollection<ProductMdl> masterCopyOfProductVersions = new ObservableCollection<ProductMdl>();
        
        
//        public static ObservableCollection<ProductMdl> getVersions()
//        {
//            ProductMdl FTM16 = new ProductMdl("Family Tree Maker 16", @"\\pr-file1\ftm\qa\FTM Patches and Installs\FTM_16\Builds\");
//            FTM16.AddFile("16-350_2007-07-11-English_GM.zip");

//            ProductMdl FTM2008 = new ProductMdl("Family Tree Make 2008", @"\\pr-file1\ftm\qa\FTM Patches and Installs\FTM_2008\Builds\");
//            FTM2008.AddFile("2008-419_2007-07-31-English_GM.zip");            

//            ProductMdl FTM2009 = new ProductMdl("Family Tree Maker 2009", @"\\pr-file1\ftm\qa\FTM Patches and Installs\FTM_2009\Builds\");
//            FTM2009.AddFile("2009-305_2008-08-13-English_GM.zip");

//            ProductMdl FTM2010 = new ProductMdl("Family Tree Maker 2010", @"\\pr-file1\ftm\qa\FTM Patches and Installs\FTM_2010\Builds\");
//            FTM2010.AddFile("2010-207_2010-01-22-English_GM");

//            ProductMdl FTM2011 = new ProductMdl("Family Tree Maker 2011", @"\\pr-file1\ftm\qa\FTM Patches and Installs\FTM_2011\Builds\");
//            FTM2011.AddFile("2011-379_2011-01-18-English_GM.zip");
//            FTM2011.AddFile("2011-376_2010-10-20-English_GM.zip");
//            FTM2011.AddFile("2011-368_2010-08-19-English_GM.zip");

//            ProductMdl FTM2012 = new ProductMdl("Family Tree Maker 2012", @"\\pr-file1\ftm\qa\FTM Patches and Installs\FTM_2012\Builds\");
//            FTM2012.AddFile("2012-723_2012-11-28-English.zip");
//            FTM2012.AddFile("2012-704_2012-09-19-English.zip");
//            FTM2012.AddFile("2012-580_2012-05-14-English.zip");
//            FTM2012.AddFile("2012-529_2012-03-05-English.zip");
//            FTM2012.AddFile("2012-506_2012-01-30-English.zip");
//            FTM2012.AddFile("2012-466_2011-12-20-English.zip");
//            FTM2012.AddFile("2012-452_2011-12-01-English.zip");
//            FTM2012.AddFile("2012-388_2011-09-08-English.zip");
//            FTM2012.AddFile("2012-312_2011-09-08-English.zip");

//            ProductMdl FTMWorldExpress = new ProductMdl("Family Tree Maker World Express", @"\\Sensei\Builds\FTM_2012_Lite\");
//            FTMWorldExpress.AddFile("2014Lite-514_2014-03-17-English.zip");
//            FTMWorldExpress.AddFile("2012World-865_2013-06-13-Swedish.zip");
//            FTMWorldExpress.AddFile("2012World-865_2013-06-13-German.zip");
//            FTMWorldExpress.AddFile("2012World-865_2013-05-22-Swedish.zip");
//            FTMWorldExpress.AddFile("2012World-865_2013-05-22-German.zip");
//            FTMWorldExpress.AddFile("2012World-865_2013-05-22-English.zip");
//            FTMWorldExpress.AddFile("2012World-864_2013-05-03-Swedish.zip");
//            FTMWorldExpress.AddFile("2012World-864_2013-05-03-German.zip");
//            FTMWorldExpress.AddFile("2012World-864_2013-05-03-English.zip");
//            FTMWorldExpress.AddFile("2012World-863_2013-04-17-Swedish.zip");
//            FTMWorldExpress.AddFile("2012World-863_2013-04-17-German.zip");
//            FTMWorldExpress.AddFile("2012World-863_2013-04-17-English.zip");
//            FTMWorldExpress.AddFile("2012World-862_2013-04-05-Swedish.zip");
//            FTMWorldExpress.AddFile("2012World-862_2013-04-05-German.zip");
//            FTMWorldExpress.AddFile("2012World-862_2013-04-04-Swedish.zip");
//            FTMWorldExpress.AddFile("2012World-862_2013-04-04-German.zip");
//            FTMWorldExpress.AddFile("2012World-862_2013-04-04-English.zip");
//            FTMWorldExpress.AddFile("2012World-861_2013-04-03-Swedish.zip");
//            FTMWorldExpress.AddFile("2012World-861_2013-04-03-German.zip");
//            FTMWorldExpress.AddFile("2012World-861_2013-04-03-English.zip");

//            ProductMdl FTM2014 = new ProductMdl("Family Tree Maker 2014", @"\\Sensei\Builds\FTM_2014\");
//            FTM2014.AddFile("2014-316_2014-09-12-English.zip");
//            FTM2014.AddFile("2014-315_2014-09-12-English.zip");
//            FTM2014.AddFile("2014-314_2014-09-10-English.zip");
//            FTM2014.AddFile("2014-313_2014-09-10-English.zip");
//            FTM2014.AddFile("2014-312_2014-09-09-English.zip");
//            FTM2014.AddFile("2014-311_2014-09-08-English.zip");
//            FTM2014.AddFile("2014-310_2014-09-05-English.zip");
//            FTM2014.AddFile("2014-309_2014-09-04-English.zip");
//            FTM2014.AddFile("2014-308_2014-09-02-English.zip");
//            FTM2014.AddFile("2014-306_2014-08-28-English.zip");
//            FTM2014.AddFile("2014-305_2014-08-27-English.zip");
//            FTM2014.AddFile("2014-304_2014-08-25-English.zip");
//            FTM2014.AddFile("2014-303_2014-08-19-English.zip");
//            FTM2014.AddFile("2014-302_2014-08-18-English.zip");
//            FTM2014.AddFile("2014-301_2014-08-18-English.zip");
//            FTM2014.AddFile("2014-300_2014-08-18-English.zip");
//            FTM2014.AddFile("2014-280_2014-04-28-English.zip");
//            FTM2014.AddFile("2014-279_2014-04-25-English.zip");
//            FTM2014.AddFile("2014-260_2014-02-11-English.zip");

//            masterCopyOfProductVersions.Add(FTM16);
//            masterCopyOfProductVersions.Add(FTM2008);
//            masterCopyOfProductVersions.Add(FTM2009);
//            masterCopyOfProductVersions.Add(FTM2010);
//            masterCopyOfProductVersions.Add(FTM2011);
//            masterCopyOfProductVersions.Add(FTM2012);
//            masterCopyOfProductVersions.Add(FTMWorldExpress);

//            return masterCopyOfProductVersions;
//        }

//        //public static List<string> getFiles(string versionName)
//        //{
//        //    List<string> temp = new List<string>();

//        //    foreach (var item in masterCopyOfProductVersions)
//        //    {
//        //        if (item.ToString() == versionName)
//        //        {
//        //            temp = item.GetFiles();
//        //        }
//        //    }
//        //    return temp;
//        //} 
//    }
//}
