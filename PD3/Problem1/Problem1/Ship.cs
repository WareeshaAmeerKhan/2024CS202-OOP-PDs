using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    internal class Ship
    {
        public string ShipNo;
        public Angle Latitude = new Angle();
        public Angle Longitude = new Angle();


        public Ship()
        {

        }

        public Ship(string SrNo, Angle latitude, Angle longitude)
        {
            ShipNo = SrNo;
            Latitude = latitude;
            Longitude = longitude;
        }

        public void FindPosition(List<Ship>ships)
        {
            Console.WriteLine("FIND POSITION:");
            Console.WriteLine("--------------");
            Console.Write("Enter Ship Serial No to find its position: ");
            string serial = Console.ReadLine();
            for(int i = 0; i < ships.Count; i++)
            {
                if (serial == ships[i].ShipNo)
                {
                    Console.WriteLine("Ship is at "+ships[i].Latitude.Degree+"\u00b0"+ ships[i].Latitude.Minute+"' "+ships[i].Latitude.Direction+" and "+ ships[i].Longitude.Degree+"\u00b0"+ships[i].Longitude.Minute+"' "+ships[i].Longitude.Direction);
                }
            }
        }

        public void ChangePosition(List<Ship>ships)
        {
            Console.Write("Enter Ship Serial No whose position you want to change: ");
            string serial = Console.ReadLine();
            for (int i = 0;i < ships.Count; i++)
            {
                if (serial == ships[i].ShipNo)
                {
                    Console.WriteLine("Enter Ship Latitude: ");
                    Console.Write("Enter Latitude's Degree: ");
                    ships[i].Latitude.Degree = int.Parse(Console.ReadLine());
                    Console.Write("Enter Latitude's Minute: ");
                    ships[i].Latitude.Minute = double.Parse(Console.ReadLine());
                    Console.Write("Enter Latitude's Direction: ");
                    ships[i].Latitude.Direction = char.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Ship Longiitude: ");
                    Console.Write("Enter Longitude's Degree: ");
                    ships[i].Longitude.Degree = int.Parse(Console.ReadLine());
                    Console.Write("Enter Longitude's Minute: ");
                    ships[i].Longitude.Minute = double.Parse(Console.ReadLine());
                    Console.Write("Enter Longitude's Direction: ");
                    ships[i].Longitude.Direction = char.Parse(Console.ReadLine());
                }
            }
        }

        public void FindSerial(List<Ship> ships)
        {
            int Lat_deg, Long_deg;
            double Lat_min, Long_min;
            char Lat_dir, Long_dir;
            Console.WriteLine("Enter Ship Latitude: ");
            Console.Write("Enter Latitude's Degree: ");
            Lat_deg = int.Parse(Console.ReadLine());
            Console.Write("Enter Latitude's Minute: ");
            Lat_min = double.Parse(Console.ReadLine());
            Console.Write("Enter Latitude's Direction: ");
            Lat_dir = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter Ship Longiitude: ");
            Console.Write("Enter Longitude's Degree: ");
            Long_deg = int.Parse(Console.ReadLine());
            Console.Write("Enter Longitude's Minute: ");
            Long_min = double.Parse(Console.ReadLine());
            Console.Write("Enter Longitude's Direction: ");
            Long_dir = char.Parse(Console.ReadLine());

            for(int i=0; i<ships.Count; i++)
            {
                if(Lat_deg == ships[i].Latitude.Degree && Lat_min == ships[i].Latitude.Minute && Lat_dir == ships[i].Latitude.Direction && Long_deg == ships[i].Longitude.Degree && Long_min == ships[i].Longitude.Minute && Long_dir == ships[i].Longitude.Direction)
                {
                        Console.WriteLine("Ship's serial number is " + ships[i].ShipNo);
                }
                else
                {
                    Console.WriteLine(".");
                }
            }
        }
    }
}
