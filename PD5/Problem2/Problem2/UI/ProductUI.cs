using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem2.BL;
using Problem2.DL;

namespace Problem2.UI
{
    internal class ProductUI
    {
        public static Product ProductInput()
        {
            Console.WriteLine("Enter Product Details:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Category: ");
            string category = Console.ReadLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Available Stock Quantity: ");
            int AvailableQuantity = int.Parse(Console.ReadLine());
            Console.Write("Minimum Stock Threshold: ");
            int MinThreshold = int.Parse(Console.ReadLine());
            return new Product(name, category, price, AvailableQuantity, MinThreshold);
        }
        public static void ViewProducts()
        {
            Console.WriteLine("All Products:");
            foreach (Product product in ProductCRUD.Products)
            {
                Console.WriteLine($"Name: {product.name}\t Category: {product.category}\t Price: {product.price}\t Available Stock Quantity: {product.AvailableQuantity}\t Minimum Stock Threshold: {product.MinThreshold}");
            }

        }
        public static void DisplayMaxPrice()
        {
            Product product = ProductCRUD.MaxPriceProduct();
            Console.WriteLine("Product with highest price is " + product.name);
        }

        public static void ViewSalesTax()
        {
            Console.WriteLine("Sales Tax of All Products:");
            foreach (Product product in ProductCRUD.Products)
            {
                Console.WriteLine($"Product: {product.name}\t Category: {product.category}\t Sales Tax In Percentage: {product.CalculateSalesTax()}%\t Sales tax in rupees: {product.Tax}");
            }
        }

        public static void DisplayProductsToBeOrdered()
        {
            List<Product> products = ProductCRUD.ProductsToBeOrder();
            Console.WriteLine("Products to be ordered are: ");
            foreach (Product product in products)
            {
                Console.WriteLine(product.name);
            }
        }
    }
}
