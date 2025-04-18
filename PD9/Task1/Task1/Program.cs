using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;
using Task1.UI;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            do
            {
                ProjectBL project = ProjectUI.TakeInput();
                if(project.Passed())
                {
                    Console.WriteLine(ProjectUI.Pass());
                }
                else
                {
                    Console.WriteLine(ProjectUI.Fail());
                }    
                Console.WriteLine("Enter 1 to continue... ");
                option= int.Parse(Console.ReadLine());
            } while (option == 1);
        }
    }
}
