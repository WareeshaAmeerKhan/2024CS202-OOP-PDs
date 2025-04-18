using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;

namespace Task1.UI
{
    internal class GradedCourseUI
    {
        public static GradedCourseBL TakeInput()
        {
            Console.Write("Enter Course Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Grade (12/10/7/4/2/0/-3): ");
            int grade = int.Parse(Console.ReadLine());
            GradedCourseBL graded = new GradedCourseBL(name, grade);
            return graded;
        }
    }
}
