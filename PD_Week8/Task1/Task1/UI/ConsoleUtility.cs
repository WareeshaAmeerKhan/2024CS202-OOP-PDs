using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.UI
{
    internal class ConsoleUtility
    {
        public static int MainMenu()
        {
            Console.WriteLine("***(MAIN MENU)***");
            Console.WriteLine();
            Console.WriteLine("1. Add Staff Details");
            Console.WriteLine("2. Add Student Details");
            Console.WriteLine("3. View Staff Details");
            Console.WriteLine("4. View Student Details");
            Console.WriteLine("5. Exit");
            Console.WriteLine();
            Console.WriteLine("Which operation you want to perform?");
            Console.Write("Enter you choice(1/2/3/4/5): ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}
