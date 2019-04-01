using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;
using System.Xml.Serialization;
using static OilRefineryTest.Tools.Misc;

namespace OilRefineryTest.Tools
{
    
    class SavedInstanceManager
    {
        private ArrayList savedPoints = new ArrayList();
        private FileStream fs;
        private BinaryFormatter bf = new BinaryFormatter();
        private Dictionary<int, ArrayList> series = new Dictionary<int, ArrayList>(); 

        private ArrayList savedInstances = new ArrayList();
        private XmlDocument xDoc = new XmlDocument();

        private const string PATHXML = "Data\\SavedInstance.xml";
        private const string PATHPOINTS = "Data\\SavedInstance.dat";
        
        public SavedInstanceManager()
        {
            if (hasSavedFileXml())
            {
                xDoc.Load(PATHXML);
            }
            else
            {
                xDoc = new XmlDocument();
            }
        }
        public void addTask(DateTime dt, string taskName, string taskDescription)
        {
            XmlElement xRoot = xDoc.DocumentElement;
            if (xRoot == null)
            {
                xRoot = xDoc.CreateElement("root");
                xDoc.AppendChild(xRoot);
            }
            XmlElement task = addNode(dt, taskName, taskDescription);//xDoc.CreateElement("task");
            xRoot.AppendChild(task); 
            save();
        }
        public void addTask(DateTime dt, string taskName, string taskDescription, int index)
        {
            XmlElement xRoot = xDoc.DocumentElement;
            //xRoot.RemoveChild(xRoot.SelectSingleNode($"task[{index + 1}]"));
            xRoot.InsertBefore(addNode(dt, taskName, taskDescription), xRoot.SelectSingleNode($"task[{index + 1}]"));
            save();
        }

        public void addPoint(int index, double x, double y, int series)
        {
            if (!this.series.ContainsKey(series))
            {
                this.series.Add(series, new ArrayList());
            }
            using (fs = new FileStream(PATHPOINTS, FileMode.OpenOrCreate))
            {
                MyPoint mp = new MyPoint();
                mp.index = index;
                mp.x = x;
                mp.y = y;
                this.series[series].Add(mp);
                bf.Serialize(fs, this.series);
            }
        }

        public void deleteTask(int index)
        {
            XmlElement xRoot = xDoc.DocumentElement;
            //var v = ;
            xRoot.RemoveChild(xRoot.SelectSingleNode($"task[{index + 1}]"));
            save();
        }
        public void save()
        {   
            if (xDoc.HasChildNodes)
            {
               xDoc.Save(PATHXML);
            }
           
        }

        public void savePoints()
        {
            using (fs = new FileStream(PATHPOINTS, FileMode.Create))
            {
                bf.Serialize(fs, series);
            }
        }
        public ArrayList loadXml()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(PATHXML);
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
                    }
                    // если узел date
                    if (childnode.Name == "date")
                    {
                        savedInstance.dateTime = childnode.InnerText;
                    }
                    // если узел description
                    if (childnode.Name == "description")
                    {
                        savedInstance.taskDescription = childnode.InnerText;
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
        public Dictionary<int, ArrayList> loadPoints()
        {
            if (hasSavedFilePoints())
            {
                using (fs = new FileStream(PATHPOINTS, FileMode.Open))
                {
                    series = (Dictionary<int, ArrayList>) bf.Deserialize(fs);
                }
            }
            return series;
        }

        public bool hasSavedFileXml()
        {
            return File.Exists(PATHXML);
        }
        public bool hasSavedFilePoints()
        {
            return File.Exists(PATHPOINTS);
        }
        public void clear()
        {
            if (hasSavedFileXml())
            {
                File.Delete(PATHXML);
                savedInstances.Clear();
            }
        }

        private ArrayList randomPointsGenerator()
        {
            MyPoint mP;
            ArrayList points = new ArrayList();
            Random rnd = new Random();
            for (int i = 0; i < 300; i++)
            {
                mP = new MyPoint();
                mP.index = rnd.Next(3);
                mP.x = i + 2;
                mP.y = i * rnd.Next(4, 20) + 2;
                points.Add(mP);
            }
            return points;
        }

        private XmlElement addNode(DateTime dt, string taskName, string taskDescription)
        {
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
            return task;
        }

    }
}
