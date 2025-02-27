using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem1.BL;

namespace Problem1.UI
{
    internal class SubjectUI
    {
        public static Subject SubjectInput()
        {
            Console.Write("Enter Subject Code: ");
            string code = Console.ReadLine();
            Console.Write("Enter Credit Hours: ");
            int creditHours = int.Parse(Console.ReadLine());
            Console.Write("Enter Subject Name: ");
            string type = Console.ReadLine();
            Console.Write("Enter Subject Registration Fees: ");
            int fees = int.Parse(Console.ReadLine());
            Subject Sub = new Subject(code,creditHours, type, fees);
            return Sub;
        }
    }
}
