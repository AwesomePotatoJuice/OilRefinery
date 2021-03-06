﻿using System;
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
            DateTime now = DateTime.Now;
            string hours = (now.Hour.ToString().Length == 1) ? "0" + now.Hour : now.Hour.ToString();
            string minutes = (now.Minute.ToString().Length == 1) ? "0" + now.Minute : now.Minute.ToString();
            monthCalendar1.SelectionEnd = now;
            textBox1.Text = "Some title " + now.ToShortDateString();
            textBox2.Text = "Some description " + now.ToShortDateString();
            maskedTextBox1.Text = hours + ":" + minutes;
        }
        public string resultName
        {
            get
            {
                return textBox1.Text;
            }
        }
        public DateTime resultDate
        {
            get
            {
                DateTime dt = monthCalendar1.SelectionEnd.Date;
                String txt = maskedTextBox1.Text.Substring(3, 2);
                dt = dt.AddHours(Double.Parse(maskedTextBox1.Text.Substring(0, 2)));
                dt = dt.AddMinutes(Double.Parse(maskedTextBox1.Text.Substring(3, 2)));
                return dt;
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

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
        public string description
        {
            get
            {
                return textBox2.Text;
            }
        }
           
    }
}
