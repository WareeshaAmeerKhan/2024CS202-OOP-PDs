using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem1.BL;
using Problem1.DL;

namespace Problem1.UI
{
    internal class DegreeUI
    {
        public static void AvailableDegrees()
        {
            Console.WriteLine("Available Degree Programs: ");
            for (int i = 0; i < DegreeCRUD.DegreesList.Count; i++)
            {
                Console.WriteLine(DegreeCRUD.DegreesList[i].title);
            }
        }
        public static DegreeProgram TakeDegreeInput()
        {
            Console.Write("Enter Degree Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Degree Duration: ");
            int duration = int.Parse(Console.ReadLine());
            Console.Write("Enter Seats For Degree: ");
            int seats = int.Parse(Console.ReadLine());
            Console.Write("Enter Degree Merit: ");
            double merit = double.Parse(Console.ReadLine());
            Console.Write("Enter Number Of Subjects You Want To Add: ");
            DegreeProgram deg = new DegreeProgram(name, duration, seats, merit);
            int subjects = int.Parse(Console.ReadLine());
            int totalCH = 0;
            for (int i = 0; i < subjects; i++)
            {
                Console.Write("Enter Subject", i + 1, ": ");
                Subject sub = SubjectUI.SubjectInput();
                totalCH += sub.CreditHours;
                if (totalCH <= 20)
                {
                    deg.ListOfSubjects.Add(sub);
                    SubjectCRUD.WriteIntoFile(sub);
                }
                else
                {
                    Console.WriteLine("Credit Hours for a degree cannot be more than 20");
                    break;
                }
            }
            return deg;
        }
        public static string DegreeInput()
        {
            Console.WriteLine("Enter Degree name: ");
            string name = Console.ReadLine();
            return name;
        }
    }
}
