using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.BL
{
    internal class AbsoluteGradedCourseBL : CourseBL
    {
        private int marks;
        private string grade;

        public AbsoluteGradedCourseBL(string course_name, int marks, string grade) : base (course_name)
        {
            this.marks = marks;
            this.grade = grade;
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

        public override bool Passed()
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
