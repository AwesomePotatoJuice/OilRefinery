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
    public partial class AddSeriesPoints : Form
    {
        public bool success { get; set; }
        public int seriesNumber { get; set; }
        public ArrayList points = new ArrayList();
        public AddSeriesPoints()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            seriesNumber = Int32.Parse(numericUpDown1.Text);
            success = true;
            Hide();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox tbParent = (TextBox) sender;
            TextBox tbX = new TextBox();
            TextBox tbY = new TextBox();

            tbX.Location = new Point(tbParent.Location.X, tbParent.Location.Y + tbParent.Size.Height * 2 + 10);
            tbY.Location = new Point(tbParent.Location.X, tbParent.Location.Y + tbParent.Size.Height * 3 + 10);

            tbX.TextChanged += textBox_TextChanged;
            Controls.Add(tbX);
            Controls.Add(tbY);

            Label labelX = new Label();
            labelX.Text = "X:";
            Controls.Add(labelX);

            Label labelY = new Label();
            labelY.Text = "Y:";
            Controls.Add(labelY);

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            success = false;
            Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox tbX = new TextBox();
            TextBox tbY = new TextBox();

            tbX.TextChanged += textBox_TextChanged;

            tbX.Location = new Point(textBox1.Location.X, textBox1.Location.Y + textBox1.Size.Height * 2 + 10);
            tbY.Location = new Point(textBox1.Location.X, textBox1.Location.Y + textBox1.Size.Height * 3 + 10);

            Controls.Add(tbX);
            Controls.Add(tbY);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            points.Add(Double.Parse(textBox1.Text));
            points.Add(Double.Parse(textBox2.Text));
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
        }
    }
}
