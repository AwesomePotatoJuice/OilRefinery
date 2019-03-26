using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilRefineryTest.Util
{
    class Notification
    {
        private DateTime dateTime;

        private String message, title;
        public bool notified = false;

        public Notification(DateTime dateTime, String message, String title)
        {
            this.dateTime = dateTime;
            this.message = message;
            this.title = title;
        }

        public DateTime getDateTime()
        {
            return dateTime;
        }

        public string getMessage()
        {
            if (message != "" && message != null)
                return message;
            else return "Message";
        }

        public string getTitle()
        {
            if (title != "" && title != null)
                return title;
            else return "Внимание!";
        }
    }
}
