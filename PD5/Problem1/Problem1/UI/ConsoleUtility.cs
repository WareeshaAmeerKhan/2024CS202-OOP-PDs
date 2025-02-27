using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.UI
{
    internal class ConsoleUtility
    {
        static int option;
        public static int MainMenu()
        {
            Console.WriteLine("*********************************************");
            Console.WriteLine("                   UAMS                      ");
            Console.WriteLine("*********************************************");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Degree Program");
            Console.WriteLine("3. Generate Merit");
            Console.WriteLine("4. View Registered Students");
            Console.WriteLine("5. View Students of a Specific Program");
            Console.WriteLine("6. Registe Subjects for a Specific Student");
            Console.WriteLine("7. Calculate Fees for all Registered Students");
            Console.WriteLine("8. Exit");
            Console.Write("Enter Option: ");
            while (!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 8)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 8.");
                Console.Write("Enter Option: ");
            }
            return option;
        }
    }
}
