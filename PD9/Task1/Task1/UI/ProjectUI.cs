using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;

namespace Task1.UI
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
            ProjectBL project = new ProjectBL(p_name, A1, A2, G1, G2);
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
