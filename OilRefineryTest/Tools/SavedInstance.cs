using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OilRefineryTest.Util;

namespace OilRefineryTest.Tools
{
    [Serializable]
    class SavedInstance
    {
        private ArrayList items = new ArrayList();

        private NotificationManager notificationManager;
        private ListView.ListViewItemCollection loadedItemsDate;
        private ListBox.ObjectCollection loadedItemsTasks;


        public void add(ArrayList controls)
        {
            loadedItemsTasks = (ListBox.ObjectCollection)controls[0];
            loadedItemsDate = (ListView.ListViewItemCollection)controls[1];
            notificationManager = (NotificationManager)controls[2];
            //items.Add(control);
        }

        public ArrayList getItems()
        {
            return items;
        }

        private void compose()
        {

        }

    }
}
