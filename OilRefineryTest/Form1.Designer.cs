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
            this.tabPane = new System.Windows.Forms.TabControl();
            this.tabPage_Temperatue = new System.Windows.Forms.TabPage();
            this.tabPage_CO2 = new System.Windows.Forms.TabPage();
            this.hintMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.tabPage_Oil = new System.Windows.Forms.TabPage();
            this.taskManager = new System.Windows.Forms.GroupBox();
            this.checkedListBox_Tasks = new System.Windows.Forms.CheckedListBox();
            this.button_AddTask = new System.Windows.Forms.Button();
            this.button_ChangeTask = new System.Windows.Forms.Button();
            this.button_DeletaTask = new System.Windows.Forms.Button();
            this.adminPane = new System.Windows.Forms.GroupBox();
            this.controlPane = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_AddData = new System.Windows.Forms.Button();
            this.button_ChangeData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPane.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.taskManager.SuspendLayout();
            this.adminPane.SuspendLayout();
            this.controlPane.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPane
            // 
            this.tabPane.Controls.Add(this.tabPage_Temperatue);
            this.tabPane.Controls.Add(this.tabPage_CO2);
            this.tabPane.Controls.Add(this.tabPage_Oil);
            this.tabPane.Location = new System.Drawing.Point(300, 27);
            this.tabPane.Name = "tabPane";
            this.tabPane.SelectedIndex = 0;
            this.tabPane.Size = new System.Drawing.Size(1450, 965);
            this.tabPane.TabIndex = 1;
            // 
            // tabPage_Temperatue
            // 
            this.tabPage_Temperatue.BackgroundImage = global::OilRefineryTest.Properties.Resources.Новый_текстовый_документ;
            this.tabPage_Temperatue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage_Temperatue.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Temperatue.Name = "tabPage_Temperatue";
            this.tabPage_Temperatue.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Temperatue.Size = new System.Drawing.Size(1442, 939);
            this.tabPage_Temperatue.TabIndex = 0;
            this.tabPage_Temperatue.Text = "Температура";
            this.tabPage_Temperatue.UseVisualStyleBackColor = true;
            // 
            // tabPage_CO2
            // 
            this.tabPage_CO2.BackgroundImage = global::OilRefineryTest.Properties.Resources.Новый_текстовый_документ;
            this.tabPage_CO2.Location = new System.Drawing.Point(4, 22);
            this.tabPage_CO2.Name = "tabPage_CO2";
            this.tabPage_CO2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_CO2.Size = new System.Drawing.Size(1442, 939);
            this.tabPage_CO2.TabIndex = 1;
            this.tabPage_CO2.Text = "Содержание CO2";
            this.tabPage_CO2.UseVisualStyleBackColor = true;
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
            // tabPage_Oil
            // 
            this.tabPage_Oil.BackgroundImage = global::OilRefineryTest.Properties.Resources.Новый_текстовый_документ;
            this.tabPage_Oil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage_Oil.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Oil.Name = "tabPage_Oil";
            this.tabPage_Oil.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Oil.Size = new System.Drawing.Size(1442, 939);
            this.tabPage_Oil.TabIndex = 2;
            this.tabPage_Oil.Text = "Распад нефтепродуктов";
            this.tabPage_Oil.UseVisualStyleBackColor = true;
            // 
            // taskManager
            // 
            this.taskManager.Controls.Add(this.adminPane);
            this.taskManager.Controls.Add(this.checkedListBox_Tasks);
            this.taskManager.Location = new System.Drawing.Point(12, 12);
            this.taskManager.Name = "taskManager";
            this.taskManager.Size = new System.Drawing.Size(282, 1003);
            this.taskManager.TabIndex = 1;
            this.taskManager.TabStop = false;
            this.taskManager.Text = "Задачи";
            // 
            // checkedListBox_Tasks
            // 
            this.checkedListBox_Tasks.FormattingEnabled = true;
            this.checkedListBox_Tasks.Location = new System.Drawing.Point(19, 19);
            this.checkedListBox_Tasks.Name = "checkedListBox_Tasks";
            this.checkedListBox_Tasks.Size = new System.Drawing.Size(167, 349);
            this.checkedListBox_Tasks.TabIndex = 0;
            // 
            // button_AddTask
            // 
            this.button_AddTask.Location = new System.Drawing.Point(0, 34);
            this.button_AddTask.Name = "button_AddTask";
            this.button_AddTask.Size = new System.Drawing.Size(75, 45);
            this.button_AddTask.TabIndex = 0;
            this.button_AddTask.Text = "Добавить задачу";
            this.button_AddTask.UseVisualStyleBackColor = true;
            this.button_AddTask.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_ChangeTask
            // 
            this.button_ChangeTask.Location = new System.Drawing.Point(0, 85);
            this.button_ChangeTask.Name = "button_ChangeTask";
            this.button_ChangeTask.Size = new System.Drawing.Size(75, 45);
            this.button_ChangeTask.TabIndex = 1;
            this.button_ChangeTask.Text = "Изменить задачу";
            this.button_ChangeTask.UseVisualStyleBackColor = true;
            this.button_ChangeTask.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_DeletaTask
            // 
            this.button_DeletaTask.Location = new System.Drawing.Point(0, 136);
            this.button_DeletaTask.Name = "button_DeletaTask";
            this.button_DeletaTask.Size = new System.Drawing.Size(75, 45);
            this.button_DeletaTask.TabIndex = 2;
            this.button_DeletaTask.Text = "Удалить задачу";
            this.button_DeletaTask.UseVisualStyleBackColor = true;
            this.button_DeletaTask.Click += new System.EventHandler(this.button3_Click);
            // 
            // adminPane
            // 
            this.adminPane.Controls.Add(this.button_DeletaTask);
            this.adminPane.Controls.Add(this.button_AddTask);
            this.adminPane.Controls.Add(this.button_ChangeTask);
            this.adminPane.Location = new System.Drawing.Point(192, 19);
            this.adminPane.Name = "adminPane";
            this.adminPane.Size = new System.Drawing.Size(84, 349);
            this.adminPane.TabIndex = 2;
            this.adminPane.TabStop = false;
            this.adminPane.Text = "Админ. панель";
            // 
            // controlPane
            // 
            this.controlPane.Controls.Add(this.groupBox1);
            this.controlPane.Controls.Add(this.panel1);
            this.controlPane.Location = new System.Drawing.Point(1756, 42);
            this.controlPane.Name = "controlPane";
            this.controlPane.Size = new System.Drawing.Size(132, 973);
            this.controlPane.TabIndex = 3;
            this.controlPane.TabStop = false;
            this.controlPane.Text = "Панель управления";
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
            // button_AddData
            // 
            this.button_AddData.Location = new System.Drawing.Point(3, 3);
            this.button_AddData.Name = "button_AddData";
            this.button_AddData.Size = new System.Drawing.Size(114, 23);
            this.button_AddData.TabIndex = 0;
            this.button_AddData.Text = "Ввести данные";
            this.button_AddData.UseVisualStyleBackColor = true;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(9, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 211);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Служебная панель";
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
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tabPane.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.taskManager.ResumeLayout(false);
            this.adminPane.ResumeLayout(false);
            this.controlPane.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_ChangeData;
        private System.Windows.Forms.Button button_AddData;
    }
}

