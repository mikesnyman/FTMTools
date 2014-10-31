using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FTMTools.Model
{
    public class InstallMdl
    {
        public void DirectoryVersion(string path)
        {
            string[] tempArray = path.Split('\\');
            string yearFolder = tempArray[tempArray.Count() - 3];
            string targetName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\TempFolder";

            // Checking to see if Main Folder where all versions are kept exists
            if (!Directory.Exists(targetName))
            {
                Directory.CreateDirectory(targetName);
            }

            // Checking to see if a years version already has been installed on this computer (only one verions per release can be installed)
            if (Directory.Exists(targetName + @"\" + yearFolder))
            {
                Console.WriteLine("Which version would you like to install?  You already have a version from this year.");
                // message box stuff to choose install most recent choice or cancel
                // uninstall process / option
            }
            else // if no version if found then install begins
            {
                targetName = targetName + @"\" + yearFolder;
                Directory.CreateDirectory(targetName);

                Unzip(targetName, path);
            }
        }

        void Unzip(string targetName, string path)
        {
            ProcessStartInfo p = new ProcessStartInfo();
            p.FileName = "7za.exe";
            p.UseShellExecute = false;
            //p.Arguments = @"x " + path +  "\" -o\"" + targetName + " -v-y";
            p.Arguments = "x \"" + path + "\" -o\"" + targetName + " -v-y";

            Process p2 = Process.Start(p);
            p2.WaitForExit();

            FindExe(targetName);
        }

        void FindExe(string folder)
        {
            try
            {
                try
                {
                    Process.Start(folder + @"\fscommand\Setup.exe");  // for FTM_16 and FTM_2010
                }
                catch
                { }
                try
                {
                    Process.Start(folder + @"\setup.exe");  // for FTM_2011 and newer
                }
                catch
                { }
            }
            catch
            {
                Console.WriteLine("Could not find Setup.exe");
            }
        }
    }
}
