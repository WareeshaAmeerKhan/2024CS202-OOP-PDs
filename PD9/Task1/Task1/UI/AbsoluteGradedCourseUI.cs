using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;

namespace Task1.UI
{
    internal class AbsoluteGradedCourseUI
    {
        public static AbsoluteGradedCourseBL TakeInput()
        {
            Console.Write("Enter Course Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Marks: ");
            int marks = int.Parse(Console.ReadLine());
            Console.Write("Enter Grade: ");
            string grade = Console.ReadLine();
            AbsoluteGradedCourseBL absolute = new AbsoluteGradedCourseBL(name , marks, grade);
            return absolute;
        }
    }
}
