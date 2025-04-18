using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.BL;

namespace Task2.UI
{
    internal class ProjectUI
    {
        public static ProjectBL TakeInput()
        {
            Console.Write("Enter Project Name: ");
            string p_name = Console.ReadLine();

            AbsoluteGradedCourseBL A1 = AbsoluteGradedCourseUI.TakeInput();
            AbsoluteGradedCourseBL A2 = AbsoluteGradedCourseUI.TakeInput();
            GradedCourseBL G1 = GradedCourseUI.TakeInput();
            GradedCourseBL G2 = GradedCourseUI.TakeInput();

            List<CourseBL> courses = new List<CourseBL>();
            courses.Add(A1);
            courses.Add(A2);
            courses.Add(G1);
            courses.Add(G2);
            ProjectBL project = new ProjectBL(p_name, courses);

            return project;
        }

        public static string Pass()
        {
            return "You are Passed!";
        }

        public static string Fail()
        {
            return "You are Failed!";
        }
    }
}
