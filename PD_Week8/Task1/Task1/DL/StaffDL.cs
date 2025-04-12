using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;

namespace Task1.DL
{
    internal class StaffDL
    {
        public static List<StaffBL> staffList = new List<StaffBL>();

        public static void AddStaff(StaffBL staff)
        {
            staffList.Add(staff);
        }

        public static List<StaffBL> GetStaffList()
        {
            return staffList;
        }
    }
}
