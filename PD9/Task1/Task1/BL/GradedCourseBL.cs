using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    internal class GradedCourseBL
    {
        private string course_name;
        private int grade;

        public GradedCourseBL(string course_name, int grade)
        {
            this.course_name = course_name;
            this.grade = grade;
        }

        public string getCourse()
        {
            return course_name;
        }

        public void setCourse(string name)
        {
            course_name = name;
        }

        public int getGrade()
        {
            return grade;
        }

        public void setGrade(int g)
        {
            grade = g;
        }

        public bool Passed()
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
