using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    internal class StaffBL : PersonBL
    {
        private string school;
        private double pay;

        public StaffBL() { }

        public StaffBL(string school, double pay)
        {
            this.school = school;
            this.pay = pay;
        }

        public string getSchool()
        {
            return this.school;
        }

        public double getPay()
        {
            return this.pay;
        }

        public void setSchool(string school)
        {
            this.school=school;
        }

        public void setPay(double pay)
        {
            this.pay = pay;
        }

        public new string toString()
        {
            string record = base.toString();
            return (record+ " School: "+ this.school+ " Pay: "+ this.pay).ToString();
        }
    }
}
