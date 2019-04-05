using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace OilRefineryTest.Tools
{
    static class UsersManager
    {
        private const string PATH_TO_USERS = "Data\\users.srl";

        private static ArrayList users = new ArrayList();
        private static BinaryFormatter bf = new BinaryFormatter();
        private static FileStream fs;

        public static void addUser(string name, string password, int type)
        {
            User user = new User{name = name, password = password, type = type};
            users.Add(user);
            Secure.createUser(user);
            user.password = "Enrcypted";
            using (fs = new FileStream(PATH_TO_USERS, FileMode.OpenOrCreate))
            {
                bf.Serialize(fs, users);
            }
        }

        public static ArrayList getUsers()
        {
            using (fs = new FileStream(PATH_TO_USERS, FileMode.OpenOrCreate))
            {
                users = (ArrayList)bf.Deserialize(fs);
            }
            return users;
        }
    }
}
