using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem2.BL;

namespace Problem2.DL
{
    internal class UserCRUD
    {
        static List<User> UserList = new List<User>();
        public static string CheckRole(string name, string pass)
        {
            foreach (User u in UserList)
            {
                if (u.name == name && pass == u.password)
                {
                    return u.role;
                }
            }
            return null;
        }
        public static User FindByCredentials(string name, string pass)
        {
            foreach (User u in UserList)
            {
                if (u.name == name && pass == u.password)
                {
                    return u;
                }
            }
            return null;
        }
        public static void AddUser(User u)
        {
            UserList.Add(u);
        }

        public static void ReadFromFile()
        {
            StreamReader f = new StreamReader("User.txt");
            string record;
            if (File.Exists("User.txt"))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] Record = record.Split(',');
                    string name = Record[0];
                    string password = Record[1];
                    string role = Record[2];
                    string email = Record[3];
                    string address = Record[4];
                    string contact = Record[5];
                    User u = new User(name, password, role, email, address, contact);
                    UserList.Add(u);
                }
                f.Close();
            }
        }

        public static void WriteInFile(User u)
        {
            using (StreamWriter f = new StreamWriter("User.txt", true))
            {
                f.WriteLine();
                f.Write($"{u.name}, {u.password}, {u.role}, {u.email}, {u.address}, {u.contact}");
            }
        }
    }
}
