using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.DL;
using Task1.UI;
using Task1.BL;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                int choice = ConsoleUtility.MainMenu();
                switch(choice)
                {
                    case 1:
                        StaffBL staff = StaffUI.AddStaff();
                        StaffDL.AddStaff(staff);
                        break;
                    case 2:
                        StudentBL student = StudentUI.AddStudent();
                        StudentDL.AddStudent(student);
                        break;
                    case 3:
                        List<StaffBL> stf = StaffDL.GetStaffList();
                        StaffUI.ViewStaff(stf);
                        break;
                    case 4:
                        List<StudentBL> stu = StudentDL.GetStudentList();
                        StudentUI.ViewStudent(stu);
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
                if (choice == 5)
                    break;
            }

        }
    }
}
