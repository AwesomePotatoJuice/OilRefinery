using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
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
        
        public void add(Object date, Object name, Object notification)
        {
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

        public void append(DateTime dt, string taskName, string taskDescription)
        {

            XmlElement xRoot = xDoc.DocumentElement;
            if (xRoot != null)
            {
                xRoot = xDoc.CreateElement("root");
            }
            XmlElement element = xDoc.CreateElement("task");
            XmlAttribute name = xDoc.CreateAttribute("name");
            XmlAttribute date = xDoc.CreateAttribute("date");
            XmlAttribute description = xDoc.CreateAttribute("description");
            XmlText nameText = xDoc.CreateTextNode(taskName);
            XmlText dateText = xDoc.CreateTextNode(dt.ToString());
            XmlText descriptionText = xDoc.CreateTextNode(taskDescription);
            name.AppendChild(nameText);
            date.AppendChild(dateText);
            description.AppendChild(descriptionText);
            element.Attributes.Append(name);
            element.Attributes.Append(date);
            element.Attributes.Append(description);
            xRoot.AppendChild(element);

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
