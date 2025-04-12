using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    internal class StudentBL : PersonBL
    {
        private string program;
        private int year;
        private double fee;

        public StudentBL() { }
        public StudentBL(string program, int year, double fee)
        {
            this.program = program;
            this.year = year;
            this.fee = fee;
        }

        public string getProgram()
        {
            return this.program;
        }

        public int getYear()
        {
            return this.year;
        }

        public double getFee()
        {
            return this.fee;
        }

        public void setProgram(string program)
        {
            this.program = program;
        }

        public void setYear(int year)
        {
            this.year = year;
        }

        public void setFee(double fee)
        {
            this.fee = fee;
        }

        public new string toString()
        {
            string record = base.toString();
            return (record+ " Program: "+ program+ " Year: "+ year+ " Fee: "+ fee).ToString();
        }
    }
}
