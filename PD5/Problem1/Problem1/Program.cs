using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem1.BL;
using Problem1.DL;
using Problem1.UI;

namespace Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SubjectCRUD.ReadFromFile();
            DegreeCRUD.ReadFromFile();
            StudentCRUD.ReadFromFile();
            int op;
            while (true)
            {
                op = ConsoleUtility.MainMenu();
                if (op == 1)
                {
                    Student s = StudentUI.AddStudent();
                    StudentCRUD.AddStudent(s);
                    StudentCRUD.WriteIntoFile(s);
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if (op == 2)
                {
                    DegreeProgram d = DegreeUI.TakeDegreeInput();
                    DegreeCRUD.AddDegree(d);
                    DegreeCRUD.WriteIntoFile(d);
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if (op == 3)
                {
                    StudentCRUD.RegisterStudentInDegrees();
                    StudentUI.DisplayResult();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if (op == 4)
                {
                    StudentUI.DisplayRegisteredStudents();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if (op == 5)
                {
                    string degree = DegreeUI.DegreeInput();
                    StudentUI.DisplayStudent(degree);
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if (op == 6)
                {
                    string name = StudentUI.RegisterIntoSubject();
                    Student s = StudentCRUD.SearchStudent(name);
                    if (s != null)
                    {
                        StudentUI.DisplaySubjects(s);
                        s.RegisterSubjects(StudentUI.RegisterSubjects(s));
                    }
                    else
                    {
                        Console.WriteLine("Student not found.");
                    }
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if (op == 7)
                {
                    StudentUI.DisplayFees();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if (op == 8)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option.");
                }
                Console.Clear();
            }
        }
    }
}
