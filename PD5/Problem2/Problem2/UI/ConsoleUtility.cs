using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.UI
{
    internal class ConsoleUtility
    {
        public static int Menu()
        {
            int op;
            Console.WriteLine("<<< Departmental Store Management System >>>");
            Console.WriteLine("Choose operation to perform: ");
            Console.WriteLine("1. Sign In.");
            Console.WriteLine("2. Sign Up.");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Your option: ");
            op = int.Parse(Console.ReadLine());
            return op;
        }
    }
}
