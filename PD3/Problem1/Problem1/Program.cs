using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Angle Latitude = new Angle(134, 23.7, 'X');
            Angle Longitude = new Angle(29, 12.6, 'Y');
            Ship s1 = new Ship("CS202",Latitude,Longitude );
            List<Ship> ships = new List<Ship>() {s1};

            int choice = Menu();
            
            while (choice != 0)
            {
                if (choice > 5)
                {
                    Console.Write("Invalid option! Try again: ");
                    choice = int.Parse(Console.ReadLine());
                    Console.WriteLine("-----------------------");
                }

                if (choice == 1)
                {
                    AddShip(ships);
                    choice = Menu();
                    continue;
                }

                else if (choice == 2)
                {
                    Ship s = new Ship();
                    s.FindPosition(ships);
                    choice = Menu();
                    continue;
                }

                else if(choice == 3)
                {
                    Ship s = new Ship();
                    s.FindSerial(ships);
                    choice = Menu();
                    continue;
                }

                else if (choice == 4)
                {
                    Ship s = new Ship();
                    s.ChangePosition(ships);
                    choice = Menu();
                    continue;
                }

                else
                {

                }
            }
        }

        static int Menu()
        {
            int choice;
            Console.WriteLine("-----------------------");
            Console.WriteLine("1. Add Ship");
            Console.WriteLine("2. View Ship Position");
            Console.WriteLine("3. View Ship Serial Number");
            Console.WriteLine("4. Change Ship Position");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------");
            return choice;
        }

        static void AddShip(List<Ship>ships)
        {
            Ship s = new Ship();
            Console.Write("Enter Ship Number: ");
            s.ShipNo = Console.ReadLine();

            Console.WriteLine("Enter Ship Latitude: ");
            Console.Write("Enter Latitude's Degree: ");
            s.Latitude.Degree = int.Parse(Console.ReadLine());
            Console.Write("Enter Latitude's Minute: ");
            s.Latitude.Minute = double.Parse(Console.ReadLine());
            Console.Write("Enter Latitude's Direction: ");
            s.Latitude.Direction = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter Ship Longiitude: ");
            Console.Write("Enter Longitude's Degree: ");
            s.Longitude.Degree = int.Parse(Console.ReadLine());
            Console.Write("Enter Longitude's Minute: ");
            s.Longitude.Minute = double.Parse(Console.ReadLine());
            Console.Write("Enter Longitude's Direction: ");
            s.Longitude.Direction = char.Parse(Console.ReadLine());

            ships.Add(s);
        }
    }
}
