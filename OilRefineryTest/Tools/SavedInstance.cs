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
        public Object dateTime
        {
            get { return dt; }
            set
            {
                string str = (value).ToString();
                switch (str.Length)
                {
                    case 19:
                        dt = new DateTime(Int32.Parse(str.Substring(6, 4)),
                            Int32.Parse(str.Substring(3, 2)),
                            Int32.Parse(str.Substring(0, 2)),
                            Int32.Parse(str.Substring(11, 2)),
                            Int32.Parse(str.Substring(14, 2)),
                            Int32.Parse(str.Substring(17, 2)));
                        break;
                    case 18:
                        dt = new DateTime(Int32.Parse(str.Substring(6, 4)),
                            Int32.Parse(str.Substring(3, 2)),
                            Int32.Parse(str.Substring(0, 2)),
                            Int32.Parse(str.Substring(11, 1)),
                            Int32.Parse(str.Substring(13, 2)),
                            Int32.Parse(str.Substring(16, 2)));
                        break;
                }

                
            }
        }

        private DateTime dt;

        public string taskName { get; set; }
        public string taskDescription { get; set; }
    }
}
