using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.BL;
using Task2.UI;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            do
            {
                ProjectBL project = ProjectUI.TakeInput();
                List<CourseBL> courses=project.GetList();
                int passedCount = 0;
                
                foreach (CourseBL c in courses)
                {
                    if (c.Passed())
                    {
                        passedCount++;
                    }
                }

                if(passedCount >= 3)
                {
                    Console.WriteLine(ProjectUI.Pass());
                }
                else
                {
                    Console.WriteLine(ProjectUI.Fail());
                }

                Console.WriteLine("Enter 1 to continue... ");
                option = int.Parse(Console.ReadLine());
            } while (option == 1);
        }
    }
}
