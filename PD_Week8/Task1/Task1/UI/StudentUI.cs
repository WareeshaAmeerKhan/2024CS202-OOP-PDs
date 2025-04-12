using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;

namespace Task1.UI
{
    internal class StudentUI
    {
        public static StudentBL AddStudent()
        {
            StudentBL student = new StudentBL();
            PersonBL person = PersonUI.InputMenu();
            string name = person.getName();
            student.setName(name);
            string address = person.getAddress();
            student.setAddress(address);
            Console.Write("Enter Program: ");
            string program = Console.ReadLine();
            student.setProgram(program);
            Console.Write("Enter Year: ");
            int year = int.Parse(Console.ReadLine());
            student.setYear(year);
            Console.Write("Enter Fee: ");
            double fee = double.Parse(Console.ReadLine());
            student.setFee(fee);
            return student;
        }

        public static void ViewStudent(List<StudentBL> stu)
        {
            List<StudentBL> students = stu;
            foreach (StudentBL s in students)
            {
                Console.WriteLine(s.toString());
            }
        }
    }
}
