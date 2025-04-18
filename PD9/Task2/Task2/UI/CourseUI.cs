using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.BL;

namespace Task2.UI
{
    internal class CourseUI
    {
        public static string TakeInput()
        {
            Console.Write("Enter Course Name: ");
            string name = Console.ReadLine();
            return name;
        }
    }
}
