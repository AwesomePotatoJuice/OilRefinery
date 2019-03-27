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
        private ArrayList savedInstances = new ArrayList();
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
            if (xRoot == null)
            {
                xRoot = xDoc.CreateElement("root");
                xDoc.AppendChild(xRoot);
            }
            XmlElement task = xDoc.CreateElement("task");

            XmlElement name = xDoc.CreateElement("name");
            XmlElement date = xDoc.CreateElement("date");
            XmlElement description = xDoc.CreateElement("description");

            XmlText nameText = xDoc.CreateTextNode(taskName);
            XmlText dateText = xDoc.CreateTextNode(dt.ToString());
            XmlText descriptionText = xDoc.CreateTextNode(taskDescription);

            
            name.AppendChild(nameText);
            date.AppendChild(dateText);
            description.AppendChild(descriptionText);

            task.AppendChild(name);
            task.AppendChild(date);
            task.AppendChild(description);

            xRoot.AppendChild(task);
        }

        public void save()
        {
            xDoc.Save(PATH);
            //bf.Serialize(fs, savedInstance);
        }

        public ArrayList load()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(PATH);
            // получим корневой элемент
            XmlElement xRoot = xDoc.DocumentElement;
            // обход всех узлов в корневом элементе
            foreach (XmlNode xnode in xRoot)
            {
                // обходим все дочерние узлы элемента task
                SavedInstance savedInstance = new SavedInstance { dateTime = DateTime.Now, taskDescription = "description", taskName = "taskName" };
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    // если узел - name
                    if (childnode.Name == "name")
                    {
                        savedInstance.taskName = childnode.InnerText;
                        Console.WriteLine("name: {0}", childnode.InnerText);
                    }
                    // если узел date
                    if (childnode.Name == "date")
                    {
                        savedInstance.dateTime = childnode.InnerText;
                        Console.WriteLine("date: {0}", childnode.InnerText);
                    }
                    // если узел description
                    if (childnode.Name == "description")
                    {
                        savedInstance.taskDescription = childnode.InnerText;
                        Console.WriteLine("description: {0}", childnode.InnerText);
                    }
                }
                savedInstances.Add(savedInstance);
            }
            //if (fs == null)
            //{
            //    Directory.CreateDirectory("Data");
            //    fs = new FileStream("Data\\SavedInstanceManager.dat", FileMode.OpenOrCreate);
            //}

            //return (((SavedInstance) bf.Deserialize(fs)).getItems());
            return savedInstances;
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
                savedInstances.Clear();
            }
        }
        
    }
}
