using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    internal class AbsoluteGradedCourseBL
    {
        private string course_name;
        private int marks;
        private string grade;

        public AbsoluteGradedCourseBL(string course_name, int marks, string grade)
        {
            this.course_name = course_name;
            this.marks = marks;
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

        public int getMarks()
        {
            return marks;
        }

        public void setMarks(int m)
        {
            marks = m;
        }

        public string getGrade()
        {
            return grade;
        }

        public void setGrade(string g)
        {
            grade = g;
        }

        public bool Passed()
        {
            if (marks >= 50)
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
