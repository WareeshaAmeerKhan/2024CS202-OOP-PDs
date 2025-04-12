using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;

namespace Task1.DL
{
    internal class StudentDL
    {
        public static List<StudentBL> studentList = new List<StudentBL>();

        public static void AddStudent(StudentBL student)
        {
            studentList.Add(student);
        }

        public static List<StudentBL> GetStudentList()
        {
            return studentList;
        }
    }
}
