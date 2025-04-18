using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.BL
{
    internal class ProjectBL
    {
        private string P_Name;
        private List<CourseBL> courses;

        public ProjectBL(string p_Name, List<CourseBL> courses)
        {
            P_Name = p_Name;
            this.courses = courses;
        }

        public List<CourseBL> GetList()
        {
            return courses;
        }
    }
}
