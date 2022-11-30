using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNAeb
{
    public static class AuthorizedUser
    {
        public static int ID { get; private set; }
        public static string FIO { get; private set; }
        public static string Role { get; private set; }

        public static void SetUser(int id, string fio, string role)
        {
            ID = id;
            FIO = fio;
            Role = role;
        }
    }
}
