using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Player1 Name: ");
            string p1 = Console.ReadLine();
            Console.Write("Enter its health value: ");
            double h1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter its energy value: ");
            double e1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter its armor value: ");
            double a1 = double.Parse(Console.ReadLine());

            Console.Write("Enter Player2 Name: ");
            string p2 = Console.ReadLine();
            Console.Write("Enter its health value: ");
            double h2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter its energy value: ");
            double e2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter its armor value: ");
            double a2 = double.Parse(Console.ReadLine());

            Player Attacker = new Player(p1, h1, e1, a1);
            Player Target = new Player(p2,h2,e2,a2);

            Console.Write("Enter Skill Name: ");
            string skill = Console.ReadLine();
            Console.Write("Enter Damage value: ");
            double damage = double.Parse(Console.ReadLine());
            Console.Write("Enter Penetration value: ");
            double penetration = double.Parse(Console.ReadLine());
            Console.Write("Enter Heal value: ");
            double heal = double.Parse(Console.ReadLine());
            Console.Write("Enter Cost: ");
            double cost = double.Parse(Console.ReadLine());
            Console.Write("Enter Skill Description: ");
            string description = Console.ReadLine();


            Stats Skill = new Stats(skill, damage, penetration, heal, cost, description);

            Attacker.LearnSkill(Skill);

            string output = Attacker.Attack(Attacker,Target);
            Console.WriteLine(output);

        }
    }
}
