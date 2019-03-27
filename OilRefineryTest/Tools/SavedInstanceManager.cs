using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;

namespace OilRefineryTest.Tools
{
    [Serializable]
    class SavedInstanceManager
    {

        private XmlDocument xDoc = new XmlDocument();
        private const string PATH = "Data\\SavedInstance.xml";

        //private SavedInstance savedInstance = new SavedInstance();
        //private ArrayList itemsSet = new ArrayList(3);
        //private FileStream fs;
        //BinaryFormatter bf = new BinaryFormatter();

        public SavedInstanceManager()
        {
            if (hasSavedFile())
            {
                xDoc.Load(PATH);
            }
            else
            {
                xDoc = new XmlDocument();
            }
        }
        
        public void add(Object task, Object date, Object notification)
        {
            XmlElement element = xDoc.CreateElement("Task");
            XmlAttribute name = xDoc.CreateAttribute(task.ToString());
            //if (fs == null)
            //{
            //    Directory.CreateDirectory("Data");
            //    fs = new FileStream("Data\\SavedInstanceManager.dat", FileMode.OpenOrCreate);
            //}
            //itemsSet.Add(task);
            //itemsSet.Add(date);
            //itemsSet.Add(notification);
            //savedInstance.add(itemsSet);
        }

        public void append(DateTime dt, string taskName)
        {

        }

        public void save()
        {
            //bf.Serialize(fs, savedInstance);
        }

        public ArrayList load()
        {
            //if (fs == null)
            //{
            //    Directory.CreateDirectory("Data");
            //    fs = new FileStream("Data\\SavedInstanceManager.dat", FileMode.OpenOrCreate);
            //}

            //return (((SavedInstance) bf.Deserialize(fs)).getItems());
            return null;
        }

        public bool hasSavedFile()
        {
            return File.Exists(PATH);
        }

        public void clear()
        {
            if (hasSavedFile())
            {
                File.Delete(PATH);
            }
        }
        
    }
}
