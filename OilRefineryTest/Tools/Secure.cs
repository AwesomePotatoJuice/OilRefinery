using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OilRefineryTest.Tools
{
    class Secure
    {
        private const string PATH_TO_SHA1 = "Data\\secure.byt";
        public static byte[] ComputeHmacsha1(byte[] data, byte[] key)
        {
            using (var hmac = new HMACSHA1(key))
            {
                return hmac.ComputeHash(data);
            }
        }

        public static bool createUser(string name, string password, int type)
        {
            byte[] SHA1 = Secure.ComputeHmacsha1(Encoding.UTF8.GetBytes(password),
                Encoding.UTF8.GetBytes(name + "HELIOSONE"));
            using (FileStream fs = new FileStream(PATH_TO_SHA1, FileMode.Append))
            {
                int intValue = type;

                byte[] bytes = new byte[4];

                bytes[0] = (byte)(intValue >> 24);
                bytes[1] = (byte)(intValue >> 16);
                bytes[2] = (byte)(intValue >> 8);
                bytes[3] = (byte)intValue;
                fs.Write(bytes, 0, 4);
                fs.Write(SHA1, 0, SHA1.Length);
            }

            return true;
        }
    }
}
