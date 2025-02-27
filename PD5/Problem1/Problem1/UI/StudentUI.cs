using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem1.BL;
using Problem1.DL;

namespace Problem1.UI
{
    internal class StudentUI
    {
        static string name;
        static int age;
        static double FSCMarks;
        static double EcatMarks;

        public int total_students = 0;
        public static Student AddStudent()
        {
            Console.Write("Enter Student Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Student Age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Fsc Marks: ");
            FSCMarks = double.Parse(Console.ReadLine());
            Console.Write("Enter Student Ecat Marks: ");
            EcatMarks = double.Parse(Console.ReadLine());
            Console.WriteLine();
            DegreeUI.AvailableDegrees();
            Student s = new Student(name, age, FSCMarks, EcatMarks);
            Console.WriteLine("Enter Number Of Preferences You Want To Enter: ");
            int p = int.Parse(Console.ReadLine());
            for (int i = 0; i < p; i++)
            {
                Console.Write("Enter Preference Subject ", i + 1, ": ");
                string preference = Console.ReadLine();
                s.Preferences.Add(DegreeCRUD.AvailablePreferenceDegree(preference));
            }
            return s;
        }

        public static void DisplayResult()
        {
            foreach (Student stu in StudentCRUD.ListOfStudents)
            {
                if (stu.isRegistered)
                {
                    Console.WriteLine(stu.name + " got admission in " + stu.DegreeRegistered.title + "!");
                }
                else
                {
                    Console.WriteLine(stu.name + " did not get admission!");
                }
            }
        }

        public static void DisplayRegisteredStudents()
        {
            Console.WriteLine("Name \t FSC \t ECAT \t Age \n \n");
            foreach (Student student in StudentCRUD.ListOfStudents)
            {
                if (student.isRegistered)
                {
                    Console.WriteLine(student.name + "\t" + student.FSCMarks + "\t" + student.EcatMarks + "\t" + student.age);
                }
            }
        }

        public static void DisplayStudent(string degreeName)
        {
            Console.WriteLine("Name \t FSC \t ECAT \t Age");
            foreach (Student student in StudentCRUD.ListOfStudents)
            {
                if (student.DegreeRegistered.title == degreeName)
                {
                    Console.WriteLine(student.name + "\t" + student.FSCMarks + "\t" + student.EcatMarks + "\t" + student.age);
                }
            }
        }

        public static string RegisterIntoSubject()
        {
            Console.Write("Enter your name: ");
            string Sname = Console.ReadLine();
            return Sname;
        }

        public static void DisplaySubjects(Student s)
        {
            Console.WriteLine("Available Subjects for " + s.name + "'s degree are: \n");
            Console.WriteLine("Code \t  Type \t  Credit Hours \t Fees");
            for (int i = 0; i < s.DegreeRegistered.ListOfSubjects.Count; i++)
                Console.WriteLine(s.DegreeRegistered.ListOfSubjects[i].SubCode + " \t " + s.DegreeRegistered.ListOfSubjects[i].Type + " \t " + s.DegreeRegistered.ListOfSubjects[i].CreditHours + " \t " + s.DegreeRegistered.ListOfSubjects[i].Fee);
        }

        public static List<Subject> RegisterSubjects(Student s)
        {
            List<Subject> subjects = new List<Subject>();
            int sum = 0;
            Console.WriteLine("Enter number of subjects you want to register in: ");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter Subject Code: ");
                string SubCode = Console.ReadLine();
                Subject subj = s.DegreeRegistered.GetSubjectbyCode(SubCode);
                sum += subj.CreditHours;
                if (sum <= 9)
                {
                    subjects.Add(subj);
                    continue;
                }
                else
                {
                    Console.WriteLine("Credit hours cannot be more than 9.");
                    break;
                }
            }
            return subjects;
        }

        public static void DisplayFees()
        {
            foreach (Student student in StudentCRUD.ListOfStudents)
            {
                if (student.isRegistered)
                {
                    Console.WriteLine("Fees for " + student.name + " is: " + student.SubjectsFees());
                }
            }
        }
    }
}
