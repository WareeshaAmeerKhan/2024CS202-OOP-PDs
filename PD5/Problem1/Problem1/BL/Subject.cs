using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.BL
{
    internal class Subject
    {
        public string SubCode;
        public int CreditHours;
        public string Type;
        public int Fee;

        public Subject() { }
        public Subject(string code, int creditHours, string subjectType, int subjectFee)
        {
            SubCode = code;
            CreditHours = creditHours;
            Type = subjectType;
            Fee = subjectFee;
        }
    }
}
