using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    internal class ProjectBL
    {
        private string P_Name;
        private static AbsoluteGradedCourseBL A1;
        private static AbsoluteGradedCourseBL A2;
        private static GradedCourseBL G1;
        private static GradedCourseBL G2;

        public ProjectBL(string p_name, AbsoluteGradedCourseBL a1,  AbsoluteGradedCourseBL a2, GradedCourseBL g1, GradedCourseBL g2)
        {
            P_Name = p_name;
            A1 = a1;
            A2 = a2;
            G1 = g1;
            G2 = g2;
        }

        public bool Passed()
        {
            int passedCount = 0;
            if (A1.Passed()) passedCount++;
            if (A2.Passed()) passedCount++;
            if (G1.Passed()) passedCount++;
            if (G2.Passed()) passedCount++;

            return passedCount >= 3;
        }
    }
}
