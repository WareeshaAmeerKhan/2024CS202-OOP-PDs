using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem2.BL;

namespace Problem2.UI
{
    internal class UserUI
    {
        public static User SignUpInput()
        {
            Console.Write("Choose your name: ");
            string name = Console.ReadLine();
            Console.Write("Choose your password: ");
            string pass = Console.ReadLine();
            Console.Write("Choose your role: ");
            string role = Console.ReadLine();
            Console.Write("Choose your email: ");
            string email = Console.ReadLine();
            Console.Write("Enter your address: ");
            string address = Console.ReadLine();
            Console.Write("Enter your contact number: ");
            string contact = Console.ReadLine();
            return new User(name, pass, role, email, address, contact);
        }

        public static string SignInName()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        public static string SignInPass()
        {
            Console.Write("Enter your password: ");
            string pass = Console.ReadLine();
            return pass;
        }
    }
}
