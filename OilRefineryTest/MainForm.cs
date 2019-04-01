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
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using OilRefineryTest.Forms;
using OilRefineryTest.Tools;
using OilRefineryTest.Util;
using static OilRefineryTest.Tools.Misc;

namespace OilRefineryTest
{
    public partial class MainForm : Form
    {
        public readonly string userName;

        private const string PATH_TO_SHA1 = "Data\\secure.byt";

        private readonly SavedInstanceManager savedInstanceManager = new SavedInstanceManager();
        private readonly NotificationManager notificationManager;
        private readonly int userType;
        private ArrayList descriptions = new ArrayList();

        public MainForm()
        {
            if (!Directory.Exists("Data"))
                Directory.CreateDirectory("Data");
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
            chart_Temperature.ChartAreas[0].AxisX = new Axis() { Title = "Продолжительность наблюдения,сут" };
            chart_Temperature.ChartAreas[0].AxisY = new Axis() { Title = "Температура,С" };

            chart_CO2.ChartAreas[0].AxisX = new Axis() { Title = "Продолжительность наблюдения,сут" };
            chart_CO2.ChartAreas[0].AxisY = new Axis() { Title = "Содержание углекислоты,%" };

            chart_Oil.ChartAreas[0].AxisX = new Axis() { Title = "Продолжительность наблюдения,сут" };
            chart_Oil.ChartAreas[0].AxisY = new Axis() { Title = "Степень распада нефтепродуктов,%" };
        }
        //--------------------------------------------------------------------------------Form methods
        private void formClosing(object sender, EventArgs e)
        {
            savedInstanceManager.save();
            savedInstanceManager.savePoints();
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
            if (savedInstanceManager.hasSavedFilePoints())
            {
                Dictionary<int, ArrayList> series = savedInstanceManager.loadPoints();
                int count = series.Count;
                for (int i = 0; i < count; i++)
                {
                    if (!series.ContainsKey(i))
                    {
                        count++;
                        continue;
                    }
                    foreach (MyPoint point in series[i])
                    {
                        switch (point.index)
                        {
                            case 0:
                                if (chart_Temperature.Series.Count <= i)
                                {
                                    chart_Temperature.Series.Add(createSeries());
                                }
                                chart_Temperature.Series[i].Points.Add(new DataPoint(point.x, point.y));
                                break;
                            case 1:
                                if (chart_CO2.Series.Count <= i)
                                {
                                    chart_CO2.Series.Add(createSeries());
                                }
                                chart_CO2.Series[i].Points.Add(new DataPoint(point.x, point.y));
                                break;
                            case 2:
                                if (chart_Oil.Series.Count <= i)
                                {
                                    chart_Oil.Series.Add(createSeries());
                                }
                                chart_Oil.Series[i].Points.Add(new DataPoint(point.x, point.y));
                                break;
                        }
                    }
                }
            }
        }
        //--------------------------------------------------------------------------------Menu forms
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
        //--------------------------------------------------------------------------------Tasks editing
        private void button_AddTask_Click(object sender, EventArgs e)
        {
            AddTask addTask = new AddTask();
            addTask.ShowDialog();
            if (addTask.success())
            {
                ActionRegistrator.addRecord(DateTime.Now, Misc.getMethodName(), userName,addTask.resultName);
                this.addTask(addTask.resultDate, addTask.resultName, addTask.description);
                savedInstanceManager.addTask(addTask.resultDate, addTask.resultName, addTask.description);
            }
        }
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
                    savedInstanceManager.addTask(changeTask.resultDate, changeTask.resultName, descriptions[index].ToString(), index);
                }
            }
        }
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
        //---------------------------------------------------------------------Service----TaskEditing
        private void addTask(DateTime dt, string taskName, string taskDescription)
        {
            checkedListBox_Tasks.Items.Add(taskName);
            listView1.Items.Add(dt.ToString().Substring(0, 15));
            descriptions.Add(taskDescription);
            notificationManager.addTask(dt, taskDescription, taskName);
        }
        //---------------------------------------------------------------------User editing
        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            createUser();
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
        //---------------------------------------------------------------------Journal
        private void buttonOpenJournal_Click(object sender, EventArgs e)
        {
            ActionRegistrator.addRecord(DateTime.Now, Misc.getMethodName(), userName, "Чтение журнала");
            Journal journal = new Journal();
            journal.Show();
        }
        //--------------------------------------------------------------------------------Points editing
        private void button_AddPoint_Click(object sender, EventArgs e)
        {
            var points = getDataPointCollection(0);
            InputBox inputBox = points.Count != 0 ? new InputBox(points.Last().XValue, points.Last().YValues.Last()) : new InputBox(0, 0);
            inputBox.ShowDialog();
            if (inputBox.success())
            {
                points.Add(new DataPoint(inputBox.result[0], inputBox.result[1]));

                ActionRegistrator.addRecord(DateTime.Now, Misc.getMethodName(), userName, inputBox.result[0].ToString() + inputBox.result[1].ToString());
                savedInstanceManager.addPoint(tabPane.SelectedIndex, inputBox.result[0], inputBox.result[1], 0);
            }
        }
        private void buttonAddPrevDate_Click(object sender, EventArgs e)
        {

            AddSeriesPoints addSeriesPoints = new AddSeriesPoints();
            addSeriesPoints.ShowDialog();
            if (addSeriesPoints.success)
            {
                var points = getDataPointCollection(addSeriesPoints.seriesNumber);
                for (int i = 0; i < addSeriesPoints.points.Count; i += 2)
                {
                    points.Add(new DataPoint((double)addSeriesPoints.points[i], (double)addSeriesPoints.points[i + 1]));
                    savedInstanceManager.addPoint(tabPane.SelectedIndex, (double)addSeriesPoints.points[i],
                        (double)addSeriesPoints.points[i + 1], addSeriesPoints.seriesNumber);
                }
            }
        }
        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            Dictionary<double, double>[] dictArray = argegatePoints();
            addAproxPoints(dictArray[0], dictArray[1], dictArray[2]);
        }
        private void buttonDeleteSeries_Click(object sender, EventArgs e)
        {
            DeleteSeries deleteSeries = new DeleteSeries();
            deleteSeries.ShowDialog();
            if (deleteSeries.success)
            {
                var tabPage = tabPane.TabPages[tabPane.SelectedIndex];
                Chart chart = (Chart)tabPage.GetChildAtPoint(new Point(10, 10));
                chart.Series.RemoveAt(deleteSeries.series - 1);
            }
        }
        //---------------------------------------------------------------------Service----Points editing
        private DataPointCollection getDataPointCollection(int index)
        {
            var tabPage = tabPane.TabPages[tabPane.SelectedIndex];
            Chart chart = (Chart)tabPage.GetChildAtPoint(new Point(10, 10));
            if (chart.Series.Count <= index)
            {
                chart.Series.Add(createSeries());
            }
            return chart.Series[index].Points;
        }
        private Series createSeries()
        {
            Series series = new Series();
            series.ChartType = SeriesChartType.FastLine;
            return series;
        }
        private Dictionary<double, double>[] argegatePoints()
        {
            Dictionary<double, double> pointsMapTemperature = new Dictionary<double, double>();
            Dictionary<double, double> pointsMapCO2 = new Dictionary<double, double>();
            Dictionary<double, double> pointsMapOil = new Dictionary<double, double>();
            bool first = true;
            foreach (Series series in chart_Temperature.Series)
            {
                if (first)
                {
                    first = false;
                    continue;
                }

                foreach (DataPoint point in series.Points)
                {
                    if (pointsMapTemperature.ContainsKey(point.XValue))
                    {
                        double xp = point.XValue;
                        double yp = point.YValues[0];
                        double xm = xp;
                        double ym = pointsMapTemperature[xp];
                        ym = (ym + yp)/2;
                        pointsMapTemperature[point.XValue] = (pointsMapTemperature[point.XValue] + point.YValues[0]) / 2;
                    }
                    else pointsMapTemperature.Add(point.XValue, point.YValues[0]);
                }
            }

            pointsMapTemperature = pointsMapTemperature.OrderBy(pair => pair.Key).ToDictionary(pair => pair.Key, pair => pair.Value);


            foreach (Series series in chart_CO2.Series)
            {

                for (int i = 1; i < chart_CO2.Series.Count; i++)
                {
                    foreach (DataPoint points in chart_CO2.Series[i].Points)
                    {
                        if (pointsMapCO2.ContainsKey(points.XValue))
                        {
                            pointsMapCO2[points.XValue] = (pointsMapCO2[points.XValue] + points.YValues.Last()) / 2;
                        }
                        else pointsMapCO2.Add(points.XValue, points.YValues.Last());
                    }
                }
            }
            foreach (Series series in chart_Oil.Series)
            {
                for (int i = 1; i < chart_Oil.Series.Count; i++)
                {
                    foreach (DataPoint points in chart_Oil.Series[i].Points)
                    {
                        if (pointsMapOil.ContainsKey(points.XValue))
                        {
                            pointsMapOil[points.XValue] = (pointsMapOil[points.XValue] + points.YValues.Last()) / 2;
                        }
                        else pointsMapOil.Add(points.XValue, points.YValues.Last());
                    }
                }
            }
            
            return new Dictionary<double, double>[3]{pointsMapTemperature, pointsMapCO2, pointsMapCO2};
        }
        private void addAproxPoints(Dictionary<double, double> pointsMapTemperature, 
                                    Dictionary<double, double> pointsMapCO2, 
                                    Dictionary<double, double> pointsMapOil)
        {
            Series aprox1 = createSeries();
            //aprox1.Name = "Aprox1";
            chart_Temperature.Series.Add(aprox1);
            foreach (KeyValuePair<double, double> point in pointsMapTemperature)
            {
                aprox1.Points.AddXY(point.Key, point.Value);
            }
            Series aprox2 = createSeries();
            //aprox2.Name = "Aprox2";
            chart_CO2.Series.Add(aprox2);
            foreach (KeyValuePair<double, double> point in pointsMapCO2)
            {
                aprox2.Points.Add(point.Key, point.Value);
            }
            Series aprox3 = createSeries();
            //aprox3.Name = "Aprox3";
            chart_CO2.Series.Add(aprox3);
            foreach (KeyValuePair<double, double> point in pointsMapOil)
            {
                aprox3.Points.Add(point.Key, point.Value);
            }
        }

        






        //-----------------------------------------------------------------------Testing
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
                    Array.Copy(byteBufferAllFile, count * 24, byteBufferType, 0, 4);
                    Array.Copy(byteBufferAllFile, count * 24 + 4, byteBufferSHA1, 0, 20);

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
                } while (count < fs.Length / 24);
            }
        }
        private void buttonTestJournal_Click(object sender, EventArgs e)
        {
            ActionRegistrator.addRecord(DateTime.Now, Misc.getMethodName(), userName, "ТЕСТ ЖУРНАЛ КЛИК");
            ArrayList readed = ActionRegistrator.readRecord();
            MessageBox.Show(readed[0].ToString() + readed[1].ToString() + readed[2].ToString());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            /* ---------------------------------------------------Test notification
            notificationManager.addTask(DateTime.Now.AddSeconds(2), "Тестовая запись", "Тест");
            notificationManager.addTask(DateTime.Now.AddSeconds(10));
            */
        }

        
    }
}