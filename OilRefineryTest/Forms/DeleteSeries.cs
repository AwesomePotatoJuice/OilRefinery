using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OilRefineryTest.Forms
{
    public partial class DeleteSeries : Form
    {
        public bool success;
        public int series;
        public DeleteSeries()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            success = false;
            Hide();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            series = Int32.Parse(numericUpDown1.Text);
            success = true;
            Hide();
        }
    }
}
