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
    public partial class InputBox : Form
    {
        private bool ok;
        public InputBox(double x, double y)
        {
            InitializeComponent();
            numericUpDown1.Text = x.ToString();
            numericUpDown2.Text = y.ToString();
        }
        
        public double[] result
        {
            get
            {
                return new double[]
                {
                    Double.Parse(numericUpDown1.Text), Double.Parse(numericUpDown2.Text)
                };
            }
        }

        public bool success()
        {
            return ok;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ok = true;
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ok = false;
            Hide();
        }
    }
}
