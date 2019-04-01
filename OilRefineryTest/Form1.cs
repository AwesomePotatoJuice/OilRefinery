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
using System.IO;
using System.Security.Cryptography;
using System.Diagnostics;

namespace OilRefineryTest
{
    public partial class Form1 : Form
    {
        private readonly SavedInstanceManager savedInstanceManager = new SavedInstanceManager();
        private readonly NotificationManager notificationManager;
        private const string PATH_TO_SHA1 = "Data\\secure.byt";
        private ArrayList descriptions = new ArrayList();

        private readonly int userType;// = 2;
        public readonly string userName;// = "system";
        //private ArrayList usersList = new ArrayList();
        public Form1()
        {
            Login login = new Login();
            if (login.userType != 4)
            {
                login.ShowDialog();
            }
            userType = login.userType;
            userName = login.userName;
            login.Close();
            InitializeComponent();
            if (userType == 0)
            {
                adminPane.Visible = false;
                userPane.Visible = false;
                servicePane.Visible = false;
                testPane.Visible = false;
            }
            if (userType == 1)
            {
                servicePane.Visible = false;
            }
            this.WindowState = FormWindowState.Maximized;
            notificationManager = new NotificationManager(notifyIcon1);
            this.FormClosing += formClosing;
            loadData();

            if (userType == 4)
            {
                UserCreate userCreate = new UserCreate(4);
                do
                {
                    userCreate.ShowDialog();
                    Secure.createUser(userCreate.userName, userCreate.password, userCreate.userType);
                } while (!userCreate.success);
                
            }
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
                ActionRegistrator.addRecord(DateTime.Now, Misc.getMethodName(), userName, "Добавление задачи");
                this.addTask(addTask.resultDate, addTask.resultName, addTask.description);
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
                    ActionRegistrator.addRecord(DateTime.Now, Misc.getMethodName(), userName, changeTask.resultName);
                    int index = checkedListBox_Tasks.SelectedIndex;
                    checkedListBox_Tasks.Items.RemoveAt(index);
                    checkedListBox_Tasks.Items.Insert(index, changeTask.resultName);
                    listView1.Items.RemoveAt(index);
                    listView1.Items.Insert(index, changeTask.resultDate.ToString().Substring(0, 16));
                    notificationManager.addTask(changeTask.resultDate, changeTask.description, changeTask.resultName);
                    savedInstanceManager.deleteTask(index);
                    savedInstanceManager.addTask(changeTask.resultDate, changeTask.resultName, "description", index);
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
                    ActionRegistrator.addRecord(DateTime.Now, Misc.getMethodName(), userName, checkedListBox_Tasks.Items[index].ToString());
                    checkedListBox_Tasks.Items.RemoveAt(index);
                    listView1.Items.RemoveAt(index);
                    descriptions.RemoveAt(index);
                    savedInstanceManager.deleteTask(index);
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
                ActionRegistrator.addRecord(DateTime.Now, Misc.getMethodName(), userName, inputBox.result[0].ToString() + inputBox.result[1].ToString());
                points.Add(new DataPoint(inputBox.result[0], inputBox.result[1]));
                savedInstanceManager.addPoint(tabPane.SelectedIndex, inputBox.result[0], inputBox.result[1]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActionRegistrator.addRecord(DateTime.Now, Misc.getMethodName(), userName, "БУТОН КЛИК");
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
            notificationManager.addTask(dt, taskDescription, taskName);
        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            createUser();
        }

        private void button_CheckSecureSystem_Click(object sender, EventArgs e)
        {
            ActionRegistrator.addRecord(DateTime.Now, Misc.getMethodName(), userName, "ЧЕК СЕКЬЮР СИСТЕМ КЛИК");
            using (FileStream fs = new FileStream(PATH_TO_SHA1, FileMode.Open))
            {
                byte[] byteBufferAllFile = new byte[fs.Length];
                fs.Read(byteBufferAllFile, 0, byteBufferAllFile.Length);

                byte[] byteBufferType = new byte[4];
                byte[] byteBufferSHA1 = new byte[20];
                int count = 0;
                do
                {
                    Array.Copy(byteBufferAllFile, count*24, byteBufferType, 0, 4);
                    Array.Copy(byteBufferAllFile, count*24 + 4, byteBufferSHA1, 0, 20);

                    byte[] SHA1 = Secure.ComputeHmacsha1(Encoding.UTF8.GetBytes(textBox_passwordCheck.Text),
                        Encoding.UTF8.GetBytes(textBox_userNameCheck.Text + "HELIOSONE"));

                    if (SHA1.SequenceEqual(byteBufferSHA1))
                    {
                        if (byteBufferType[3] == 1) textBox_userType.Text = "ADMIN";
                        else
                        {
                            if (byteBufferType[3] == 2) textBox_userType.Text = "SYSTEM";
                            else textBox_userType.Text = "USER";
                        }
                    }

                    count++;
                } while (count < fs.Length/24);
            }
        }

        private void createUser()
        {
            UserCreate userCreate = new UserCreate();
            userCreate.ShowDialog();
            if (userCreate.success)
            {
                ActionRegistrator.addRecord(DateTime.Now, Misc.getMethodName(), userName, userCreate.userName);
                Secure.createUser(userCreate.userName, userCreate.password, userCreate.userType);
            }
        }

        private void buttonTestJournal_Click(object sender, EventArgs e)
        {
            ActionRegistrator.addRecord(DateTime.Now, Misc.getMethodName(), userName, "ТЕСТ ЖУРНАЛ КЛИК");
            ArrayList readed = ActionRegistrator.readRecord();
            MessageBox.Show(readed[0].ToString() + readed[1].ToString() + readed[2].ToString());
        }

        private void buttonOpenJournal_Click(object sender, EventArgs e)
        {
            ActionRegistrator.addRecord(DateTime.Now, Misc.getMethodName(), userName, "Чтение журнала");
            Journal journal = new Journal();
            journal.ShowDialog();
            journal.Close();
        }
    }
}
