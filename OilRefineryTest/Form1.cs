using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OilRefineryTest.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using OilRefineryTest.Tools;
using OilRefineryTest.Util;
using Timer = System.Threading.Timer;
using System.Collections;

namespace OilRefineryTest
{
    public partial class Form1 : Form
    {
        private readonly SavedInstanceManager savedInstanceManager = new SavedInstanceManager();
        private readonly NotificationManager notificationManager;
        private ArrayList descriptions = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            notificationManager = new NotificationManager(notifyIcon1);
            this.FormClosing += formClosing;
            loadData();
        }


        //Открытия окна About
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        //Добавление задачи в коллекцию через админ панель
        private void button_AddTask_Click(object sender, EventArgs e)
        {
            AddTask addTask = new AddTask();
            addTask.ShowDialog();
            if (addTask.success())
            {
                this.addTask(addTask.resultDate, addTask.resultName, addTask.description);
                //checkedListBox_Tasks.Items.Add(addTask.resultName);
                //listView1.Items.Add(addTask.resultDate.ToString().Substring(0, 15));
                //descriptions.Add(addTask.description);
                //notificationManager.addTask(addTask.resultDate, addTask.resultName);
                savedInstanceManager.addTask(addTask.resultDate, addTask.resultName, addTask.description);
            }
        }
        //Изменение задачи в коллекции через админ панель
        private void button_ChangeTask_Click(object sender, EventArgs e)
        {
            if (checkedListBox_Tasks.SelectedIndex != -1)
            {
                ChangeTask changeTask = new ChangeTask();
                changeTask.ShowDialog();
                if (changeTask.success())
                {
                    int index = checkedListBox_Tasks.SelectedIndex;
                    checkedListBox_Tasks.Items.RemoveAt(index);
                    checkedListBox_Tasks.Items.Insert(index, changeTask.resultName);
                    listView1.Items.Insert(index, changeTask.resultDate.ToString().Substring(0, 16));
                    notificationManager.addTask(changeTask.resultDate, changeTask.resultName);
                }
            }
        }
        //Удаление задачи в коллекции через админ панель
        private void button_DeleteTask_Click(object sender, EventArgs e)
        {
            
            if (checkedListBox_Tasks.SelectedIndex != -1)
            {
                DeleteAcceptor deleteAcceptor = new DeleteAcceptor();
                deleteAcceptor.ShowDialog();
                int index = checkedListBox_Tasks.SelectedIndex;
                if (deleteAcceptor.success())
                { 
                    checkedListBox_Tasks.Items.RemoveAt(index);
                    listView1.Items.RemoveAt(index);
                }
            }
        }
        //Добавление точки в элемент Chart через панель управления
        private void button_AddPoint_Click(object sender, EventArgs e)
        {
            //Получение активной страницы таб панэли
            var tabPage = tabPane.TabPages[tabPane.SelectedIndex];
            //Получение элемента Chart
            Chart chart = (Chart)tabPage.GetChildAtPoint(new Point(10, 10));
            var points = chart.Series[chart.Series.Count - 1].Points;
            //Передача последней точки в окно ввода, если имеется и ввод новой точки
            InputBox inputBox = points.Count != 0 ? new InputBox(points.Last().XValue, points.Last().YValues.Last()) : new InputBox(0, 0);
            inputBox.ShowDialog();
            if (inputBox.success())
            {
                points.Add(new DataPoint(inputBox.result[0], inputBox.result[1]));
                savedInstanceManager.addPoint(tabPane.SelectedIndex, inputBox.result[0], inputBox.result[1]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //notificationManager.addTask(DateTime.Now.AddSeconds(10));
        }

        private void formClosing(object sender, EventArgs e)
        {
            savedInstanceManager.save();
            savedInstanceManager.savePoints();
            //savedInstanceManager.clear();
            //savedInstanceManager.addPoint(checkedListBox_Tasks.Items, listView1.Items, notificationManager);
            //savedInstanceManager.save();
        }

        private void loadData()
        {
            if (savedInstanceManager.hasSavedFileXml())
            {
                ArrayList ar = savedInstanceManager.loadXml();
                foreach (SavedInstance savedInstance in ar)
                {
                    addTask((DateTime)savedInstance.dateTime, savedInstance.taskName, savedInstance.taskDescription);
                }
            }

            if (true)//savedInstanceManager.hasSavedFilePoints())
            {
                foreach (myPoint point in savedInstanceManager.loadPoints())
                {
                    switch (point.index)
                    {
                        case 0:
                            chart_Temperature.Series[0].Points.Add(new DataPoint(point.x,point.y));
                            break;
                        case 1:
                            chart_CO2.Series[0].Points.Add(new DataPoint(point.x, point.y));
                            break;
                        case 2:
                            chart_Oil.Series[0].Points.Add(new DataPoint(point.x, point.y));
                            break;
                    }
                }

            }
            //if (savedInstanceManager.hasSavedFileXml())
            //{
            //    loadedItemsTasks = (ListBox.ObjectCollection) savedInstanceManager.loadXml()[0];
            //    loadedItemsDate = (ListView.ListViewItemCollection) savedInstanceManager.loadXml()[1];
            //    notificationManager = (NotificationManager) savedInstanceManager.loadXml()[2];
            //    listView1.Items.AddRange(loadedItemsDate);
            //    checkedListBox_Tasks.Items.AddRange(loadedItemsTasks);
            //}

        }

        private void addTask(DateTime dt, string taskName, string taskDescription)
        {
            checkedListBox_Tasks.Items.Add(taskName);
            listView1.Items.Add(dt.ToString().Substring(0, 15));
            descriptions.Add(taskDescription);
            notificationManager.addTask(dt, taskName);
        }
    }
}
