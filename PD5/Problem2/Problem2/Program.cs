using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem2.BL;
using Problem2.DL;
using Problem2.UI;

namespace Problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserCRUD.ReadFromFile();
            ProductCRUD.ReadFromFile();
            while (true)
            {
                Console.Clear();
                int op = ConsoleUtility.Menu();
                if (op == 1)
                {
                    string name = UserUI.SignInName();
                    string password = UserUI.SignInPass();
                    string role = UserCRUD.CheckRole(name, password);
                    User u = UserCRUD.FindByCredentials(name, password);
                    if (role == "Admin" || role == "admin")
                    {
                        while (true)
                        {
                            Console.Clear();
                            AdminUI.Login();
                            int ch = AdminUI.AdminMenu();
                            if (ch == 1)
                            {
                                Product p = ProductUI.ProductInput();
                                ProductCRUD.AddProduct(p);
                                ProductCRUD.WriteInFile(p);
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                            }
                            else if (ch == 2)
                            {
                                ProductUI.ViewProducts();
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                            }
                            else if (ch == 3)
                            {
                                ProductUI.DisplayMaxPrice();
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                            }
                            else if (ch == 4)
                            {
                                ProductUI.ViewSalesTax();
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                            }
                            else if (ch == 5)
                            {
                                ProductUI.DisplayProductsToBeOrdered();
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                            }
                            else if (ch == 6)
                            {
                                u.ViewAdmin();
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                            }
                            else if (ch == 7)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid option.");
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                            }
                        }

                    }
                    else if (role == "Customer" || role == "customer")
                    {
                        while (true)
                        {
                            Console.Clear();
                            CustomerUI.Login();
                            int ch = CustomerUI.CustomerMenu();
                            if (ch == 1)
                            {
                                ProductUI.ViewProducts();
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                            }
                            else if (ch == 2)
                            {
                                CustomerUI.Buy(u);
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                            }
                            else if (ch == 3)
                            {
                                CustomerUI.GenerateInvoice(u);
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                            }
                            else if (ch == 4)
                            {
                                u.ViewCustomer();
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                            }
                            else if (ch == 5)
                            {
                                Console.WriteLine("Exiting...");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid option.");
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                            }
                        }
                    }
                }
                else if (op == 2)
                {
                    User u = UserUI.SignUpInput();
                    UserCRUD.AddUser(u);
                    UserCRUD.WriteInFile(u);
                }
                else if (op == 3)
                {
                    Console.WriteLine("Exiting...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }
        }
    }
}
