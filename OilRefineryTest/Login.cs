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
using OilRefineryTest.Tools;
using OilRefineryTest.Util;
using System.Collections;
using static OilRefineryTest.Tools.Misc;

namespace OilRefineryTest
{
    public partial class Login : Form
    {
        private const string PATH_TO_SHA1 = "Data\\secure.byt";
        private const string PATH_TO_USESRS = "Data\\users.srl";
        public int userType { get; set; }
        public string userName { get; set; }
        public Login()
        {
            InitializeComponent();
           
            if (!File.Exists(PATH_TO_SHA1))
            {
                userType = 4;
                ActionRegistrator.addRecord(DateTime.Now, Misc.getMethodName(), "Первичный запуск", "-");
                Hide();
                return;
            }

            if (File.Exists(PATH_TO_USESRS))
            {
                comboBox1.Items.AddRange(getUsersString());
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream(PATH_TO_SHA1, FileMode.Open))
            {
                byte[] byteBufferAllFile = new byte[fs.Length];
                fs.Read(byteBufferAllFile, 0, byteBufferAllFile.Length);

                byte[] byteBufferType = new byte[4];
                byte[] byteBufferSHA1 = new byte[20];
                int count = 0;
                do
                {
                    Array.Copy(byteBufferAllFile, count * 24, byteBufferType, 0, 4);
                    Array.Copy(byteBufferAllFile, count * 24 + 4, byteBufferSHA1, 0, 20);

                    byte[] SHA1 = Secure.ComputeHmacsha1(Encoding.UTF8.GetBytes(textBox_password.Text),
                        Encoding.UTF8.GetBytes(comboBox1.Text + "HELIOSONE"));

                    if (SHA1.SequenceEqual(byteBufferSHA1))
                    {
                        if (byteBufferType[3] == 0)
                        {
                            userName = comboBox1.Text;
                            userType = 0;
                            break;
                        }
                        if (byteBufferType[3] == 1)
                        {
                            userName = comboBox1.Text;
                            userType = 1;
                            break;
                        }

                        if (byteBufferType[3] == 2)
                        {
                            userName = comboBox1.Text;
                            userType = 2;
                            break;
                        }
                        
                    }
                    else
                    {
                        userType = -1;
                    }

                    count++;
                } while (count < fs.Length / 24);
            }

            if (userType != -1)
            {
                ActionRegistrator.addRecord(DateTime.Now, Misc.getMethodName(), userName, "-");
                Hide();
            }
            else
            {
                userName = (userName == null || userName == "") ? "Неизвестно" : userName;
                MessageBox.Show("Неверные имя пользователя или пароль", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                ActionRegistrator.addRecord(DateTime.Now, Misc.getMethodName(), userName, "Неудачная попытка входа.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private string[] getUsersString()
        {
            List<string> list = new List<string>();
            foreach (User user in UsersManager.getUsers())
            {
                if (user.type == (int) UserType.USER)
                {
                    list.Add(user.name);
                }
            }
            return list.ToArray();
        }
    }
}
