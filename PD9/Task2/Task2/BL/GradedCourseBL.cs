using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.BL
{
    internal class GradedCourseBL : CourseBL
    {
        private int grade;

        public GradedCourseBL(string course_name, int grade) : base (course_name) 
        {
            this.grade = grade;
        }

        public int getGrade()
        {
            return grade;
        }

        public void setGrade(int g)
        {
            grade = g;
        }

        public override bool Passed()
        {
            if (grade >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
