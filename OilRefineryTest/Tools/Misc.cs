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
    }
}
