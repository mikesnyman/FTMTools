using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace FTMTools.ViewModel
{
    public class NamePathMasterCollectionMdl : INotifyPropertyChanged
    {
        public NamePathMasterCollectionMdl() { }

        private Dictionary<string, string> _namePath = new Dictionary<string, string>();
        public Dictionary<string, string> NamePath
        {
            get { return _namePath; }
            set { _namePath = value; }
        }

        public Dictionary<string,string> GetPaths()
        {
            using (XmlReader reader = XmlReader.Create("paths.xml"))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name)
                        {
                            case "Paths":
                                break;

                            case "Version":
                                string name = reader["name"];
                                string path = reader["path"];
                                NamePath.Add(name, path);
                                break;
                        }

                    }
                }
            }
            return NamePath;
        }


        public void SetPaths()
        {
            //NamePathMasterCollectionMdl namesPaths = new NamePathMasterCollectionMdl();

            //System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(NamePathMasterCollectionMdl));

            //StreamWriter file = new StreamWriter("paths.xml");
            //writer.Serialize(file, namesPaths);
            //file.Close();

            using (StreamWriter writer = new StreamWriter("paths.txt"))
            {
                Dictionary<string, string> temp = new Dictionary<string, string>();
                foreach (var item in NamePath)
                {
                    temp.Add(item.Key, item.Value);
                }

                NamePath = null;
                foreach (var item in temp)
                {
                    writer.WriteLine(item.Key);
                    writer.WriteLine(item.Value);
                    NamePath.Add(item.Key, item.Value);
                }
            }

            //using (XmlWriter writer = XmlWriter.Create("paths.xml"))
            //{
            //    writer.WriteStartDocument();
            //    writer.WriteStartElement("Paths");

            //    foreach(var item in VersionPath)
            //    {
            //        writer.WriteElementString("name", item.Key);
            //        writer.WriteElementString("path", item.Value);
            //    }
            //    writer.WriteEndElement();
            //    writer.WriteEndDocument();
            //}
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(
            [CallerMemberName] string caller = "" )
        {
            if ( PropertyChanged != null )
            {
                PropertyChanged(this,
                    new PropertyChangedEventArgs(caller));
            }
        }
    }
} 