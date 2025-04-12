using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;

namespace Task1.UI
{
    internal class PersonUI
    {
        public static PersonBL InputMenu()
        {
            Console.WriteLine("Enter Person Details: ");
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Address: ");
            string address = Console.ReadLine();
            PersonBL person = new PersonBL(name, address);
            return person;
        }
    }
}
