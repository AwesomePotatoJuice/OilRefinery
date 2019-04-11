using System;
using System.Collections;
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
    public partial class ConditionsEditing : Form
    {
        public bool success { get; set; }
        public ArrayList conditions = new ArrayList(9);
        public ConditionsEditing(ArrayList conditions)
        {
            InitializeComponent();
            if (conditions != null || conditions.Count > 9)
            {
                this.conditions = conditions;

                textBox1.Text = ((double) conditions[0]).ToString();
                textBox2.Text = ((double) conditions[1]).ToString();
                textBox3.Text = ((double) conditions[2]).ToString();
                textBox4.Text = ((double) conditions[3]).ToString();
                textBox5.Text = ((double) conditions[4]).ToString();
                textBox6.Text = ((double) conditions[5]).ToString();
                textBox9.Text = ((double) conditions[6]).ToString();
                textBox8.Text = ((double) conditions[7]).ToString();
                textBox7.Text = ((double) conditions[8]).ToString();
            }
            else
            {
                textBox1.Text = "0";
                textBox2.Text = "0";
                textBox3.Text = "0";
                textBox4.Text = "0";
                textBox5.Text = "0";
                textBox6.Text = "0";
                textBox9.Text = "0";
                textBox8.Text = "0";
                textBox7.Text = "0";
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            success = true;
            conditions.RemoveAt(0);
            conditions.Insert(0, Double.Parse(textBox1.Text));
            conditions.RemoveAt(1);
            conditions.Insert(1, Double.Parse(textBox2.Text));
            conditions.RemoveAt(2);                         
            conditions.Insert(2, Double.Parse(textBox3.Text));
            conditions.RemoveAt(3);                         
            conditions.Insert(3, Double.Parse(textBox4.Text));
            conditions.RemoveAt(4);                         
            conditions.Insert(4, Double.Parse(textBox5.Text));
            conditions.RemoveAt(5);                         
            conditions.Insert(5, Double.Parse(textBox6.Text));
            conditions.RemoveAt(6);                         
            conditions.Insert(6, Double.Parse(textBox9.Text));
            conditions.RemoveAt(7);                         
            conditions.Insert(7, Double.Parse(textBox8.Text));
            conditions.RemoveAt(8);                         
            conditions.Insert(8, Double.Parse(textBox7.Text));
            Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            success = false;
            Hide();
        }

        private void buttonAccept1_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (var tb in panel1.Controls)
            {
                if (tb.GetType() == typeof(TextBox))
                {
                    switch (i)
                    {
                        case 0:
                            conditions.Insert(i, Double.Parse(((TextBox)tb).Text));
                            break;
                        case 1:
                            conditions.Insert(i, Double.Parse(((TextBox)tb).Text));
                            break;
                        case 2:
                            conditions.Insert(i, Double.Parse(((TextBox)tb).Text));
                            break;
                    }
                    i++;
                }
            }
        }

        private void buttonAccept2_Click(object sender, EventArgs e)
        {
            int i = 3;
            foreach (var tb in panel2.Controls)
            {
                if (tb.GetType() == typeof(TextBox))
                {
                    switch (i)
                    {
                        case 3:
                            conditions.Insert(i, Double.Parse(((TextBox)tb).Text));
                            break;
                        case 4:
                            conditions.Insert(i, Double.Parse(((TextBox)tb).Text));
                            break;
                        case 5:
                            conditions.Insert(i, Double.Parse(((TextBox)tb).Text));
                            break;
                    }
                    i++;
                }
            }
        }

        private void buttonAccept3_Click(object sender, EventArgs e)
        {
            int i = 6;
            foreach (var tb in panel3.Controls)
            {
                if (tb.GetType() == typeof(TextBox))
                {
                    switch (i)
                    {
                        case 6:
                            conditions.Insert(i, Double.Parse(((TextBox)tb).Text));
                            break;
                        case 7:
                            conditions.Insert(i, Double.Parse(((TextBox)tb).Text));
                            break;
                        case 8:
                            conditions.Insert(i, Double.Parse(((TextBox)tb).Text));
                            break;
                    }
                    i++;
                }
            }
        }
    }
}
