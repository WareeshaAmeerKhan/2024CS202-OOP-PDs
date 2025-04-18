using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.BL;

namespace Task2.UI
{
    internal class GradedCourseUI
    {
        public static GradedCourseBL TakeInput()
        {
            string course = CourseUI.TakeInput();
            Console.Write("Enter Grade (12/10/7/4/2/0/-3): ");
            int grade = int.Parse(Console.ReadLine());
            GradedCourseBL graded = new GradedCourseBL(course, grade);
            return graded;
        }
    }
}
