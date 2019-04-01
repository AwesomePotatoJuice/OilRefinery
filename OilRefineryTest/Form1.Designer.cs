namespace OilRefineryTest
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPane = new System.Windows.Forms.TabControl();
            this.tabPage_Temperatue = new System.Windows.Forms.TabPage();
            this.chart_Temperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage_CO2 = new System.Windows.Forms.TabPage();
            this.chart_CO2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage_Oil = new System.Windows.Forms.TabPage();
            this.chart_Oil = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.hintMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.taskManager = new System.Windows.Forms.GroupBox();
            this.testPane = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox_userType = new System.Windows.Forms.TextBox();
            this.button_CheckSecureSystem = new System.Windows.Forms.Button();
            this.textBox_passwordCheck = new System.Windows.Forms.TextBox();
            this.textBox_userNameCheck = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.adminPane = new System.Windows.Forms.GroupBox();
            this.userPane = new System.Windows.Forms.GroupBox();
            this.buttonOpenUserList = new System.Windows.Forms.Button();
            this.buttonChangeUser = new System.Windows.Forms.Button();
            this.buttonCreateUser = new System.Windows.Forms.Button();
            this.button_DeletaTask = new System.Windows.Forms.Button();
            this.button_AddTask = new System.Windows.Forms.Button();
            this.button_ChangeTask = new System.Windows.Forms.Button();
            this.checkedListBox_Tasks = new System.Windows.Forms.CheckedListBox();
            this.controlPane = new System.Windows.Forms.GroupBox();
            this.servicePane = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonAddPrevData = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_ChangeData = new System.Windows.Forms.Button();
            this.button_AddData = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.refiningStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPane.SuspendLayout();
            this.tabPage_Temperatue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Temperature)).BeginInit();
            this.tabPage_CO2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_CO2)).BeginInit();
            this.tabPage_Oil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Oil)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.taskManager.SuspendLayout();
            this.testPane.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.adminPane.SuspendLayout();
            this.userPane.SuspendLayout();
            this.controlPane.SuspendLayout();
            this.servicePane.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refiningStateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane
            // 
            this.tabPane.Controls.Add(this.tabPage_Temperatue);
            this.tabPane.Controls.Add(this.tabPage_CO2);
            this.tabPane.Controls.Add(this.tabPage_Oil);
            this.tabPane.Location = new System.Drawing.Point(388, 27);
            this.tabPane.Name = "tabPane";
            this.tabPane.SelectedIndex = 0;
            this.tabPane.Size = new System.Drawing.Size(1362, 965);
            this.tabPane.TabIndex = 1;
            // 
            // tabPage_Temperatue
            // 
            this.tabPage_Temperatue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage_Temperatue.Controls.Add(this.chart_Temperature);
            this.tabPage_Temperatue.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Temperatue.Name = "tabPage_Temperatue";
            this.tabPage_Temperatue.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Temperatue.Size = new System.Drawing.Size(1354, 939);
            this.tabPage_Temperatue.TabIndex = 0;
            this.tabPage_Temperatue.Text = "Температура";
            this.tabPage_Temperatue.UseVisualStyleBackColor = true;
            // 
            // chart_Temperature
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_Temperature.ChartAreas.Add(chartArea1);
            this.chart_Temperature.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Name = "Legend1";
            this.chart_Temperature.Legends.Add(legend1);
            this.chart_Temperature.Location = new System.Drawing.Point(3, 3);
            this.chart_Temperature.Name = "chart_Temperature";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Black;
            series1.MarkerBorderWidth = 2;
            series1.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series1.Name = "Series1";
            series1.ToolTip = "#VALX{N} #VAL{N}";
            series1.YValuesPerPoint = 4;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.Blue;
            series2.MarkerBorderWidth = 2;
            series2.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            series2.Name = "Series2";
            this.chart_Temperature.Series.Add(series1);
            this.chart_Temperature.Series.Add(series2);
            this.chart_Temperature.Size = new System.Drawing.Size(1348, 930);
            this.chart_Temperature.TabIndex = 1;
            // 
            // tabPage_CO2
            // 
            this.tabPage_CO2.Controls.Add(this.chart_CO2);
            this.tabPage_CO2.Location = new System.Drawing.Point(4, 22);
            this.tabPage_CO2.Name = "tabPage_CO2";
            this.tabPage_CO2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_CO2.Size = new System.Drawing.Size(1354, 939);
            this.tabPage_CO2.TabIndex = 1;
            this.tabPage_CO2.Text = "Содержание CO2";
            this.tabPage_CO2.UseVisualStyleBackColor = true;
            // 
            // chart_CO2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_CO2.ChartAreas.Add(chartArea2);
            this.chart_CO2.Dock = System.Windows.Forms.DockStyle.Top;
            legend2.Name = "Legend1";
            this.chart_CO2.Legends.Add(legend2);
            this.chart_CO2.Location = new System.Drawing.Point(3, 3);
            this.chart_CO2.Name = "chart_CO2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series2";
            this.chart_CO2.Series.Add(series3);
            this.chart_CO2.Series.Add(series4);
            this.chart_CO2.Size = new System.Drawing.Size(1348, 930);
            this.chart_CO2.TabIndex = 1;
            // 
            // tabPage_Oil
            // 
            this.tabPage_Oil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage_Oil.Controls.Add(this.chart_Oil);
            this.tabPage_Oil.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Oil.Name = "tabPage_Oil";
            this.tabPage_Oil.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Oil.Size = new System.Drawing.Size(1354, 939);
            this.tabPage_Oil.TabIndex = 2;
            this.tabPage_Oil.Text = "Распад нефтепродуктов";
            this.tabPage_Oil.UseVisualStyleBackColor = true;
            // 
            // chart_Oil
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_Oil.ChartAreas.Add(chartArea3);
            this.chart_Oil.Dock = System.Windows.Forms.DockStyle.Top;
            legend3.Name = "Legend1";
            this.chart_Oil.Legends.Add(legend3);
            this.chart_Oil.Location = new System.Drawing.Point(3, 3);
            this.chart_Oil.Name = "chart_Oil";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series2";
            this.chart_Oil.Series.Add(series5);
            this.chart_Oil.Series.Add(series6);
            this.chart_Oil.Size = new System.Drawing.Size(1348, 930);
            this.chart_Oil.TabIndex = 0;
            // 
            // hintMenuItem
            // 
            this.hintMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.hintMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.hintMenuItem.Name = "hintMenuItem";
            this.hintMenuItem.Size = new System.Drawing.Size(65, 20);
            this.hintMenuItem.Text = "Справка";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hintMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1900, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(300, 992);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1447, 23);
            this.progressBar.TabIndex = 2;
            // 
            // taskManager
            // 
            this.taskManager.Controls.Add(this.testPane);
            this.taskManager.Controls.Add(this.listView1);
            this.taskManager.Controls.Add(this.adminPane);
            this.taskManager.Controls.Add(this.checkedListBox_Tasks);
            this.taskManager.Location = new System.Drawing.Point(12, 12);
            this.taskManager.Name = "taskManager";
            this.taskManager.Size = new System.Drawing.Size(370, 1003);
            this.taskManager.TabIndex = 1;
            this.taskManager.TabStop = false;
            this.taskManager.Text = "Задачи";
            // 
            // testPane
            // 
            this.testPane.Controls.Add(this.groupBox1);
            this.testPane.Controls.Add(this.textBox_userType);
            this.testPane.Controls.Add(this.button_CheckSecureSystem);
            this.testPane.Controls.Add(this.textBox_passwordCheck);
            this.testPane.Controls.Add(this.textBox_userNameCheck);
            this.testPane.Controls.Add(this.button2);
            this.testPane.Location = new System.Drawing.Point(7, 374);
            this.testPane.Name = "testPane";
            this.testPane.Size = new System.Drawing.Size(357, 254);
            this.testPane.TabIndex = 4;
            this.testPane.TabStop = false;
            this.testPane.Text = "Test panel";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(9, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Journal test";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "НАЖАТЬ КНОПКУ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonTestJournal_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 57);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Открыть журнал";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonOpenJournal_Click);
            // 
            // textBox_userType
            // 
            this.textBox_userType.Location = new System.Drawing.Point(215, 38);
            this.textBox_userType.Name = "textBox_userType";
            this.textBox_userType.Size = new System.Drawing.Size(100, 20);
            this.textBox_userType.TabIndex = 7;
            // 
            // button_CheckSecureSystem
            // 
            this.button_CheckSecureSystem.Location = new System.Drawing.Point(116, 64);
            this.button_CheckSecureSystem.Name = "button_CheckSecureSystem";
            this.button_CheckSecureSystem.Size = new System.Drawing.Size(93, 38);
            this.button_CheckSecureSystem.TabIndex = 6;
            this.button_CheckSecureSystem.Text = "Check secure system";
            this.button_CheckSecureSystem.UseVisualStyleBackColor = true;
            this.button_CheckSecureSystem.Click += new System.EventHandler(this.button_CheckSecureSystem_Click);
            // 
            // textBox_passwordCheck
            // 
            this.textBox_passwordCheck.Location = new System.Drawing.Point(215, 85);
            this.textBox_passwordCheck.Name = "textBox_passwordCheck";
            this.textBox_passwordCheck.Size = new System.Drawing.Size(100, 20);
            this.textBox_passwordCheck.TabIndex = 5;
            // 
            // textBox_userNameCheck
            // 
            this.textBox_userNameCheck.Location = new System.Drawing.Point(215, 64);
            this.textBox_userNameCheck.Name = "textBox_userNameCheck";
            this.textBox_userNameCheck.Size = new System.Drawing.Size(100, 20);
            this.textBox_userNameCheck.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.listView1.Location = new System.Drawing.Point(7, 20);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(110, 348);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // adminPane
            // 
            this.adminPane.Controls.Add(this.userPane);
            this.adminPane.Controls.Add(this.button_DeletaTask);
            this.adminPane.Controls.Add(this.button_AddTask);
            this.adminPane.Controls.Add(this.button_ChangeTask);
            this.adminPane.Location = new System.Drawing.Point(280, 19);
            this.adminPane.Name = "adminPane";
            this.adminPane.Size = new System.Drawing.Size(84, 349);
            this.adminPane.TabIndex = 2;
            this.adminPane.TabStop = false;
            this.adminPane.Text = "Админ. панель";
            // 
            // userPane
            // 
            this.userPane.Controls.Add(this.buttonOpenUserList);
            this.userPane.Controls.Add(this.buttonChangeUser);
            this.userPane.Controls.Add(this.buttonCreateUser);
            this.userPane.Location = new System.Drawing.Point(0, 205);
            this.userPane.Name = "userPane";
            this.userPane.Size = new System.Drawing.Size(84, 144);
            this.userPane.TabIndex = 4;
            this.userPane.TabStop = false;
            this.userPane.Text = "Учетные записи";
            // 
            // buttonOpenUserList
            // 
            this.buttonOpenUserList.Location = new System.Drawing.Point(0, 109);
            this.buttonOpenUserList.Name = "buttonOpenUserList";
            this.buttonOpenUserList.Size = new System.Drawing.Size(84, 35);
            this.buttonOpenUserList.TabIndex = 5;
            this.buttonOpenUserList.Text = "Открыть список";
            this.buttonOpenUserList.UseVisualStyleBackColor = true;
            // 
            // buttonChangeUser
            // 
            this.buttonChangeUser.Location = new System.Drawing.Point(0, 71);
            this.buttonChangeUser.Name = "buttonChangeUser";
            this.buttonChangeUser.Size = new System.Drawing.Size(84, 35);
            this.buttonChangeUser.TabIndex = 4;
            this.buttonChangeUser.Text = "Изменить";
            this.buttonChangeUser.UseVisualStyleBackColor = true;
            // 
            // buttonCreateUser
            // 
            this.buttonCreateUser.Location = new System.Drawing.Point(0, 33);
            this.buttonCreateUser.Name = "buttonCreateUser";
            this.buttonCreateUser.Size = new System.Drawing.Size(84, 35);
            this.buttonCreateUser.TabIndex = 3;
            this.buttonCreateUser.Text = "Добавить";
            this.buttonCreateUser.UseVisualStyleBackColor = true;
            this.buttonCreateUser.Click += new System.EventHandler(this.buttonCreateUser_Click);
            // 
            // button_DeletaTask
            // 
            this.button_DeletaTask.Location = new System.Drawing.Point(0, 136);
            this.button_DeletaTask.Name = "button_DeletaTask";
            this.button_DeletaTask.Size = new System.Drawing.Size(75, 45);
            this.button_DeletaTask.TabIndex = 2;
            this.button_DeletaTask.Text = "Удалить задачу";
            this.button_DeletaTask.UseVisualStyleBackColor = true;
            this.button_DeletaTask.Click += new System.EventHandler(this.button_DeleteTask_Click);
            // 
            // button_AddTask
            // 
            this.button_AddTask.Location = new System.Drawing.Point(0, 34);
            this.button_AddTask.Name = "button_AddTask";
            this.button_AddTask.Size = new System.Drawing.Size(75, 45);
            this.button_AddTask.TabIndex = 0;
            this.button_AddTask.Text = "Добавить задачу";
            this.button_AddTask.UseVisualStyleBackColor = true;
            this.button_AddTask.Click += new System.EventHandler(this.button_AddTask_Click);
            // 
            // button_ChangeTask
            // 
            this.button_ChangeTask.Location = new System.Drawing.Point(0, 85);
            this.button_ChangeTask.Name = "button_ChangeTask";
            this.button_ChangeTask.Size = new System.Drawing.Size(75, 45);
            this.button_ChangeTask.TabIndex = 1;
            this.button_ChangeTask.Text = "Изменить задачу";
            this.button_ChangeTask.UseVisualStyleBackColor = true;
            this.button_ChangeTask.Click += new System.EventHandler(this.button_ChangeTask_Click);
            // 
            // checkedListBox_Tasks
            // 
            this.checkedListBox_Tasks.FormattingEnabled = true;
            this.checkedListBox_Tasks.Location = new System.Drawing.Point(123, 19);
            this.checkedListBox_Tasks.Name = "checkedListBox_Tasks";
            this.checkedListBox_Tasks.Size = new System.Drawing.Size(135, 349);
            this.checkedListBox_Tasks.TabIndex = 0;
            // 
            // controlPane
            // 
            this.controlPane.Controls.Add(this.servicePane);
            this.controlPane.Controls.Add(this.panel1);
            this.controlPane.Location = new System.Drawing.Point(1756, 42);
            this.controlPane.Name = "controlPane";
            this.controlPane.Size = new System.Drawing.Size(132, 973);
            this.controlPane.TabIndex = 3;
            this.controlPane.TabStop = false;
            this.controlPane.Text = "Панель управления";
            // 
            // servicePane
            // 
            this.servicePane.Controls.Add(this.groupBox2);
            this.servicePane.Controls.Add(this.button1);
            this.servicePane.Location = new System.Drawing.Point(9, 173);
            this.servicePane.Name = "servicePane";
            this.servicePane.Size = new System.Drawing.Size(114, 211);
            this.servicePane.TabIndex = 1;
            this.servicePane.TabStop = false;
            this.servicePane.Text = "Служебная панель";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonAddPrevData);
            this.groupBox2.Location = new System.Drawing.Point(0, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(117, 119);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ввод прошлых данных";
            // 
            // buttonAddPrevData
            // 
            this.buttonAddPrevData.Location = new System.Drawing.Point(3, 28);
            this.buttonAddPrevData.Name = "buttonAddPrevData";
            this.buttonAddPrevData.Size = new System.Drawing.Size(114, 23);
            this.buttonAddPrevData.TabIndex = 2;
            this.buttonAddPrevData.Text = "Ввести данные";
            this.buttonAddPrevData.UseVisualStyleBackColor = true;
            this.buttonAddPrevData.Click += new System.EventHandler(this.buttonAddPrevDate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Изменить константы";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_ChangeData);
            this.panel1.Controls.Add(this.button_AddData);
            this.panel1.Location = new System.Drawing.Point(6, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 135);
            this.panel1.TabIndex = 0;
            // 
            // button_ChangeData
            // 
            this.button_ChangeData.Location = new System.Drawing.Point(3, 32);
            this.button_ChangeData.Name = "button_ChangeData";
            this.button_ChangeData.Size = new System.Drawing.Size(114, 23);
            this.button_ChangeData.TabIndex = 1;
            this.button_ChangeData.Text = "Изменить данные";
            this.button_ChangeData.UseVisualStyleBackColor = true;
            // 
            // button_AddData
            // 
            this.button_AddData.Location = new System.Drawing.Point(3, 3);
            this.button_AddData.Name = "button_AddData";
            this.button_AddData.Size = new System.Drawing.Size(114, 23);
            this.button_AddData.TabIndex = 0;
            this.button_AddData.Text = "Ввести данные";
            this.button_AddData.UseVisualStyleBackColor = true;
            this.button_AddData.Click += new System.EventHandler(this.button_AddPoint_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Visible = true;
            // 
            // refiningStateBindingSource
            // 
            this.refiningStateBindingSource.DataSource = typeof(OilRefinery.RefiningState);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1900, 1020);
            this.Controls.Add(this.controlPane);
            this.Controls.Add(this.taskManager);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.tabPane);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tabPane.ResumeLayout(false);
            this.tabPage_Temperatue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Temperature)).EndInit();
            this.tabPage_CO2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_CO2)).EndInit();
            this.tabPage_Oil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Oil)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.taskManager.ResumeLayout(false);
            this.testPane.ResumeLayout(false);
            this.testPane.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.adminPane.ResumeLayout(false);
            this.userPane.ResumeLayout(false);
            this.controlPane.ResumeLayout(false);
            this.servicePane.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.refiningStateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabPane;
        private System.Windows.Forms.TabPage tabPage_Temperatue;
        private System.Windows.Forms.TabPage tabPage_CO2;
        private System.Windows.Forms.ToolStripMenuItem hintMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TabPage tabPage_Oil;
        private System.Windows.Forms.GroupBox taskManager;
        private System.Windows.Forms.Button button_AddTask;
        private System.Windows.Forms.CheckedListBox checkedListBox_Tasks;
        private System.Windows.Forms.Button button_DeletaTask;
        private System.Windows.Forms.Button button_ChangeTask;
        private System.Windows.Forms.GroupBox adminPane;
        private System.Windows.Forms.GroupBox controlPane;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox servicePane;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_ChangeData;
        private System.Windows.Forms.Button button_AddData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Oil;
        private System.Windows.Forms.BindingSource refiningStateBindingSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Temperature;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_CO2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox testPane;
        private System.Windows.Forms.GroupBox userPane;
        private System.Windows.Forms.Button buttonOpenUserList;
        private System.Windows.Forms.Button buttonChangeUser;
        private System.Windows.Forms.Button buttonCreateUser;
        private System.Windows.Forms.Button button_CheckSecureSystem;
        private System.Windows.Forms.TextBox textBox_passwordCheck;
        private System.Windows.Forms.TextBox textBox_userNameCheck;
        private System.Windows.Forms.TextBox textBox_userType;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonAddPrevData;
    }
}

