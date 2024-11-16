using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Attendance_System
{
    internal class Account
    {
        static List<string> Users = new List<string>();
        private static void CreateDummyUsers()
        {
            Users.Add("2024-00001-BN-0");
            Users.Add("2024-00002-BN-0");
        }
        public static bool Login(string usernumber)
        {
            CreateDummyUsers();

            bool result = false;

            foreach (var user in Users)
            {
                if (user == usernumber)
                {
                    result = true;
                }
            }
            return result;
        }
    }
}
