using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OilRefineryTest.Tools;

namespace OilRefineryTest.Forms
{
    public partial class UserCreate : Form
    {
        private string name;
        private string passwordLocal;
        private int userTypeLocal;
        public bool success { get; set; }
        public UserCreate(int i)
        {
            InitializeComponent();
            if (i == 4)
            {
                comboBox_userList.Items.Add(Enumerations.userType.SYSTEM);
            }
        }
        public UserCreate()
        {
            InitializeComponent();
            comboBox_userList.Items.Add(Enumerations.userType.USER);
            comboBox_userList.Items.Add(Enumerations.userType.ADMIN);
            comboBox_userList.Items.Add(Enumerations.userType.SYSTEM);
        }
        public string userName
        {
            get { return name; }
            set { name = value; }
        }
        public string password
        {
            get { return passwordLocal; }
            set { passwordLocal = value; }
        }
        public int userType
        {
            get { return userTypeLocal; }
            set { userTypeLocal = value; }
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            success = true;
            name = textBox_userName.Text;
            passwordLocal = textBox_password.Text;
            userTypeLocal = (int)comboBox_userList.SelectedItem;
            Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            success = false;
            Hide();
        }
    }
}
