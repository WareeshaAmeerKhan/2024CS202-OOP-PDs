using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.BL
{
    internal class Product
    {
        public string name;
        public string category;
        public double price;
        public int AvailableQuantity;
        public int MinThreshold;
        public double Tax;
        public Product(string name, string category, double price, int AvailableQuantity, int MinThreshold)
        {
            this.name = name;
            this.category = category;
            this.price = price;
            this.AvailableQuantity = AvailableQuantity;
            this.MinThreshold = MinThreshold;
            Tax = (CalculateSalesTax() / 100) * price;
        }

        public double CalculateSalesTax()
        {
            if (category == "grocery" || category == "Grocery")
            {
                return 10.0;
            }
            else if (category == "fruit" || category == "Fruit")
            {
                return 5.0;
            }
            else
            {
                return 15.0;
            }
        }
    }
}
