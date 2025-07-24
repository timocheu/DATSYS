using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Utility.Password
{
    public static class Password
    {
        public static string Hash(string password)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(password));
        }
        public static string DecryptHash(string Hash)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(Hash));
        }
    }
}
