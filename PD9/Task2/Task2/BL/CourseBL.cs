using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.BL
{
    internal class CourseBL
    {
        protected static string course_name;

        public CourseBL(string name)
        {
            course_name = name;
        }

        public string getCourse()
        {
            return course_name;
        }

        public void setCourse(string name)
        {
            course_name = name;
        }

        public virtual bool Passed()
        {
            return false;
        }
    }
}
