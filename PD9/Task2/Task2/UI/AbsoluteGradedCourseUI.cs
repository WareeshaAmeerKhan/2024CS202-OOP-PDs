using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.BL;

namespace Task2.UI
{
    internal class AbsoluteGradedCourseUI
    {
        public static AbsoluteGradedCourseBL TakeInput()
        {
            string course = CourseUI.TakeInput();
            Console.Write("Enter Marks: ");
            int marks = int.Parse(Console.ReadLine());
            Console.Write("Enter Grade: ");
            string grade = Console.ReadLine();
            AbsoluteGradedCourseBL absolute = new AbsoluteGradedCourseBL(course, marks, grade);
            return absolute;
        }
    }
}
