using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace OilRefineryTest.Tools
{
    class Misc
    {
        public static string getMethodName()
        {
            return new StackTrace(1).GetFrame(0).GetMethod().Name;
        }
        public enum UserType
        {
            USER,
            ADMIN,
            SYSTEM
        }
        [Serializable]
        public struct MyPoint
        {
            public int index { get; set; }
            public double x { get; set; }
            public double y { get; set; }
        }
    }
    
}
