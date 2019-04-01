using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OilRefineryTest.Forms
{
    public partial class Journal : Form
    {
        private const string PATH_TO_FILE = "Data\\journal.byt";
        public Journal()
        {
            InitializeComponent();
            using (StreamReader sr = new StreamReader(PATH_TO_FILE))
            {
                string str = sr.ReadToEnd();
                
                string[] strArray = str.Split(new char[] {'\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < strArray.Length/4; i++)
                {
                    TextBox dateTime = new TextBox();
                    TextBox actionName = new TextBox();
                    TextBox actionAuthor = new TextBox();
                    TextBox description = new TextBox();

                    dateTime.Text = strArray[4 * i];
                    dateTime.Width = 150;
                    dateTime.ReadOnly = true;

                    actionName.Text = strArray[4 * i + 1];
                    actionName.Width = 150;
                    actionName.ReadOnly = true;

                    actionAuthor.Text = strArray[4 * i + 2];
                    actionAuthor.Width = 150;
                    actionAuthor.ReadOnly = true;

                    description.Text = strArray[4 * i + 3];
                    description.Width = 200;
                    description.ReadOnly = true;
                    description.Multiline = true;

                    tableLayoutPanel1.Controls.Add(dateTime, 0, i);
                    tableLayoutPanel1.Controls.Add(actionName, 1, i);
                    tableLayoutPanel1.Controls.Add(actionAuthor, 2, i);
                    tableLayoutPanel1.Controls.Add(description, 3, i);
                    tableLayoutPanel1.RowCount++;
                    
                }
            }
            
        }
    }
}
