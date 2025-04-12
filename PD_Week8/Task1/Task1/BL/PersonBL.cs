using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    internal class PersonBL
    {
        protected string name;
        protected string address;

        public PersonBL() { }
        public PersonBL(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public string getName()
        {
            return this.name;
        }

        public string getAddress()
        {
            return this.address;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setAddress(string address)
        {
            this.address = address;
        }

        public string toString()
        {
            return ("Name: "+ this.name+ " Address: "+ this.address).ToString();
        }
    }
}
