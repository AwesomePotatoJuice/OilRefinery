using System;
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
        
        public static void addRecord(DateTime actionTime, string actionName, string actionAutor, string specification){
            using (StreamWriter sw = new StreamWriter(PATH_TO_FILE, true))
            {
                sw.WriteLine(actionTime.ToString());
                string nameToWrite = "";
                string specificationToWrite;
                switch (actionName)
                {
                    case "button_AddTask_Click":
                        nameToWrite = "Добавление задачи";
                        specificationToWrite = specification;
                        break;
                    case "button_ChangeTask_Click":
                        nameToWrite = "Обновление задачи";
                        specificationToWrite = specification;
                        break;
                    case "button_DeleteTask_Click":
                        nameToWrite = "Удаление задачи";
                        specificationToWrite = specification;
                        break;
                    case "button_AddPoint_Click":
                        nameToWrite = "Добавление точки";
                        specificationToWrite = specification;
                        break;
                    case "button2_Click":
                        nameToWrite = "Бутон2Клик";
                        specificationToWrite = specification;
                        break;
                    case "button_CheckSecureSystem_Click":
                        nameToWrite = "ЧЕК СЕКЬЮР СИСТЕМ КЛИК";
                        specificationToWrite = specification;
                        break;
                    case "createUser":
                        nameToWrite = "Создание пользвателя";
                        specificationToWrite = specification;
                        break;
                    case "buttonTestJournal_Click":
                        nameToWrite = "Тест журнала";
                        specificationToWrite = specification;
                        break;
                    case "buttonOpenJournal_Click":
                        nameToWrite = "Чтение журнала";
                        specificationToWrite = specification;
                        break;
                    case "Login":
                        nameToWrite = "Первичный вход";
                        specificationToWrite = specification;
                        break;
                    case "buttonLogin_Click":
                        nameToWrite = "Вход пользователя";
                        specificationToWrite = specification;
                        break;
                    case "notify":
                        nameToWrite = "Оповещение пользователя";
                        specificationToWrite = specification;
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
