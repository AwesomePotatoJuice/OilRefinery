using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OilRefineryTest.Tools;

//using Timer = System.Windows.Forms.Timer;

namespace OilRefineryTest.Util
{
    class NotificationManager
    {
        //private ArrayList dateList = new ArrayList();
        //private ArrayList dateListPast = new ArrayList();
        private NotifyIcon notifyIcon;
        private ArrayList notifications = new ArrayList();
        private ArrayList notificationsOld = new ArrayList();
        public NotificationManager(NotifyIcon notifyIcon)
        {
            this.notifyIcon = notifyIcon;
        }

        internal void addTask(DateTime dateTime, String name)
        {
            //Тут  закралась избыточность и повторение кода, по-хорошему, надо исправить. По факту, хер с ним, пока работает.
            Notification notification = new Notification(dateTime, "", name);
            notifications.Add(notification);
            //dateList.Add(dateTime);
            //dateList.Sort();
            setTimer();
        }
        private void setTimer()
        {
            for (int i = 0; i < notifications.Count; i++)
            {
                if (((Notification)notifications[i]).notified) continue;
                DateTime dt = ((Notification)notifications[i]).getDateTime();
                if (dt.CompareTo(DateTime.Now) != 1)
                {
                    continue;
                }
                int delay = Convert.ToInt32(dt.Subtract(DateTime.Now).TotalMilliseconds);

                if (delay <= 1000)
                {
                   continue;
                }
                TimerCallback tm = notify;
                System.Threading.Timer timer = new System.Threading.Timer(tm, notifications[i], delay, 0);
            }
            
            //DateTime dt = (DateTime)dateList[0];
            //int delay = Convert.ToInt32(dt.Subtract(DateTime.Now).TotalMilliseconds);
            //if (delay <= 1000)
            //{
            //    dateList.RemoveAt(0);
            //    return;
            //}
            //Notification notification = null;
            //for (int i = 0; i < dateList.Count; i++)
            //{
            //    if (dateList[0].Equals(((Notification)notifications[i]).getDateTime()))
            //    {
            //        notification = (Notification)notifications[i];
            //        break;
            //    }
            //}
            //TimerCallback tm = notify;
            //System.Threading.Timer timer = new System.Threading.Timer(tm, notification, delay, 0);
        }
        private void notify(object state)
        {
            Notification notification = (Notification) state;
            notifyIcon.BalloonTipText = notification.getMessage();
            notifyIcon.BalloonTipTitle = notification.getTitle();
            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon.ShowBalloonTip(1000);
            notification.notified = true;
            ActionRegistrator.addRecord(DateTime.Now, Misc.getMethodName(), Program.form1.userName, "Оповещение пользователя");
        }
    }
}
