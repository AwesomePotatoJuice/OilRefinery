﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilRefineryTest.Util
{
    class ActionRegistrator
    {
        private const string PATH_TO_FILE = "Data\\journal.byt";
        public static void addRecord(DateTime actionTime, string actionName, string actionAutor, string specification)
        {
            using (StreamWriter sw = new StreamWriter(PATH_TO_FILE, true))
            {
                sw.WriteLine(actionTime.ToString());
                string nameToWrite = "";
                switch (actionName)
                {
                    case "button_AddTask_Click":
                        nameToWrite = "Ti Pidor";
                        break;
                    case "button_ChangeTask_Click":
                        nameToWrite = "Ti Pidor V2.0";
                        break;
                }
                sw.WriteLine(nameToWrite);
                sw.WriteLine(actionAutor);
                sw.WriteLine(specification);
            }
        }

        public static ArrayList readRecord()
        {
            ArrayList arrayList = new ArrayList();
            using (StreamReader sr = new StreamReader(PATH_TO_FILE))
            {
                arrayList.Add(sr.ReadLine());
                arrayList.Add(sr.ReadLine());
                arrayList.Add(sr.ReadLine());
                arrayList.Add(sr.ReadLine());
            }
            return arrayList;
        }
    }
}
