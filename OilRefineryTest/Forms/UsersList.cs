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
using OilRefineryTest.Tools;
using static OilRefineryTest.Tools.Misc;

namespace OilRefineryTest.Forms
{
    public partial class UsersList : Form
    {
        public UsersList(ArrayList users)
        {
            InitializeComponent();
            string type = "";
            for (int i = 0; i < users.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = ((User)users[i]).name;
                switch (((User)users[i]).type)
                {
                    case (int)UserType.ADMIN:
                        type = UserType.ADMIN.ToString();
                        break;
                    case (int)UserType.SYSTEM:
                        type = UserType.SYSTEM.ToString();
                        break;
                    case (int)UserType.USER:
                        type = UserType.USER.ToString();
                        break;
                }
                item.SubItems.Add(type);
                listView1.Items.Add(item);
                listView1.Columns[0].Width = 225;
            }
            
        }
    }
}
