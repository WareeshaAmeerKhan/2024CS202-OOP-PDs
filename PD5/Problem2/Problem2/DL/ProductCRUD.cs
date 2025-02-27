using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem2.BL;

namespace Problem2.DL
{
    internal class ProductCRUD
    {
        public static List<Product> Products = new List<Product>();

        public static void AddProduct(Product p)
        {
            Products.Add(p);
        }

        public static Product MaxPriceProduct()
        {
            Product highestPriceProduct = Products[0];
            foreach (Product product in Products)
            {
                if (product.price > highestPriceProduct.price)
                {
                    highestPriceProduct = product;
                }
            }
            return highestPriceProduct;
        }


        public static Product FindProduct(string name)
        {
            foreach (Product p in Products)
            {
                if (p.name == name)
                {
                    return p;
                }
            }
            return null;
        }

        public static List<Product> ProductsToBeOrder()
        {
            List<Product> ProductsToBeOrder = new List<Product>();
            foreach (Product product in Products)
            {
                if (product.AvailableQuantity < product.MinThreshold)
                {
                    ProductsToBeOrder.Add(product);
                }
            }
            return ProductsToBeOrder;
        }

        public static void ReadFromFile()
        {
            StreamReader file = new StreamReader("Product.txt");
            string record;
            if (File.Exists("Product.txt"))
            {
                while ((record = file.ReadLine()) != null)
                {
                    string[] Record = record.Split(',');
                    string name = Record[0];
                    string category = Record[1];
                    double price = double.Parse(Record[2]);
                    int availableStockQuantity = int.Parse(Record[3]);
                    int minimumStockThreshhold = int.Parse(Record[4]);
                    Product p = new Product(name, category, price, availableStockQuantity, minimumStockThreshhold);
                    Products.Add(p);

                }
                file.Close();
            }
        }
        public static void WriteInFile(Product RenamedProduct)
        {
            List<string> lines = new List<string>(File.ReadAllLines("Product.txt"));
            bool isFound = false;

            for (int i = 0; i < lines.Count; i++)
            {
                string[] data = lines[i].Split(',');
                if (data.Length >= 5 && data[0] == RenamedProduct.name)
                {
                    lines[i] = RenamedProduct.name + ", " + RenamedProduct.category + ", " + RenamedProduct.price+", " + RenamedProduct.AvailableQuantity + ", " +RenamedProduct.MinThreshold;
                    isFound = true;
                    break;
                }
            }
            if (isFound)
            {
                File.WriteAllLines("Product.txt", lines);
                Console.WriteLine("Product stock updated successfully!");
            }
            else
            {
                using (StreamWriter f = new StreamWriter("Product.txt", true))
                {
                    f.WriteLine(RenamedProduct.name + "," + RenamedProduct.category + "," + RenamedProduct.price + "," + RenamedProduct.AvailableQuantity + "," + RenamedProduct.MinThreshold);
                }
                Console.WriteLine("New Product Added To File!");
            }
        }

        public static void BuyProduct(string productName, int quantity, User user)
        {
            Product product = FindProduct(productName);
            if (product == null)
            {
                Console.WriteLine("Product not found.");
            }

            if (product.AvailableQuantity < quantity)
            {
                Console.WriteLine("Stock is not sufficient for " + productName + ".");
            }
            double totalCost = product.price * quantity;
            double CostWithTax = totalCost + product.Tax;
            product.AvailableQuantity -= quantity;
            ProductCRUD.WriteInFile(product);
            Console.WriteLine("Product: "+productName+"\t Quantity: "+quantity+"\t Total Cost: "+totalCost+"\t Total Cost with Tax: "+CostWithTax);
            user.Products.Add(product);
            user.totalCost += CostWithTax;
        }
    }
}