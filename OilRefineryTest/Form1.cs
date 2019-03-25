using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OilRefineryTest.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using OilRefineryTest.Util;

namespace OilRefineryTest
{
    public partial class Form1 : Form
    {
        private NotificationManager notificationManager;
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            notificationManager = new NotificationManager(notifyIcon1);
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
                checkedListBox_Tasks.Items.Add(addTask.resultName);
                listView1.Items.Add(addTask.resultDate.ToString().Substring(0, 15));
                notificationManager.addTask(addTask.resultDate, addTask.resultName);
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
                    listView1.Items.Insert(index, changeTask.resultDate.ToString().Substring(0, 15));
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
        private void button_AddData_Click(object sender, EventArgs e)
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
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
