using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;

namespace Task1.UI
{
    internal class StaffUI
    {
        public static StaffBL AddStaff()
        {
            StaffBL staff = new StaffBL();
            PersonBL person = PersonUI.InputMenu();
            string name = person.getName();
            staff.setName(name);
            string address = person.getAddress();
            staff.setAddress(address);
            Console.Write("Enter School: ");
            string school = Console.ReadLine();
            staff.setSchool(school);
            Console.Write("Enter Pay: ");
            double pay = double.Parse(Console.ReadLine());
            staff.setPay(pay);
            return staff;
        }

        public static void ViewStaff(List<StaffBL> stf)
        {
            List<StaffBL> staff = stf;
            foreach (StaffBL s in staff)
            {
                Console.WriteLine(s.toString());
            }
        }
    }
}
