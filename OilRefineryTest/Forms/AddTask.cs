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
    public partial class AddTask : Form
    {
        private bool ok;

        public AddTask()
        {
            InitializeComponent();
        }
        public string result
        {
            get
            {
                return textBox1.Text;
            }
        }
        public bool success()
        {
            return ok;
        }
        private void button_OK_Click(object sender, EventArgs e)
        {
            ok = true;
            Hide();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            ok = false;
            Hide();
        }
    }
}
