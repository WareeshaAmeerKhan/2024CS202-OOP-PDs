using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem2.BL;
using Problem2.DL;

namespace Problem2.UI
{
    internal class CustomerUI
    {
        public static int CustomerMenu()
        {
            Console.WriteLine("CUSTOMER >>");
            Console.WriteLine("Choose one of the following options: ");
            Console.WriteLine("1. View all the products.");
            Console.WriteLine("2. Buy the products.");
            Console.WriteLine("3. Generate invoice.");
            Console.WriteLine("4. View Profile (Username, Password, Email, Address and Contact Number).");
            Console.WriteLine("5. Exit.");
            Console.Write("Your Option: ");
            int op = int.Parse(Console.ReadLine());
            return op;
        }

        public static void Login()
        {
            Console.WriteLine("Successfully logged in as Customer");
        }

        public static void Buy(User user)
        {
            Console.Write("Enter the Product name you want to buy:");
            string productName = Console.ReadLine();
            Console.Write("Enter quantity you want to buy:");
            int quantity = int.Parse(Console.ReadLine());
            ProductCRUD.BuyProduct(productName, quantity, user);
        }
        public static void GenerateInvoice(User user)
        {
            if (user.Products.Count == 0)
            {
                Console.WriteLine("No products purchased.");
                return;
            }
            Console.WriteLine("Invoice:");
            Console.WriteLine($"Total Cost: {user.totalCost}");
        }
    }
}
