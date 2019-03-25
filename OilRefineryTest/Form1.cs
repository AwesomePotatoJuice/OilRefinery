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

namespace OilRefineryTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button_AddData_Click(object sender, EventArgs e)
        {
            var tabPage = tabPane.TabPages[tabPane.SelectedIndex];
            Chart chart = (Chart)tabPage.GetChildAtPoint(new Point(10, 10));
            var points = chart.Series[chart.Series.Count - 1].Points;
            InputBox inputBox = points.Count != 0 ? new InputBox(points.Last().XValue, points.Last().YValues.Last()) : new InputBox(0, 0);
            inputBox.ShowDialog();
            if (inputBox.success())
            {
                points.Add(new DataPoint(inputBox.result[0], inputBox.result[1]));
            }
        }
    }
}
