using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    internal class Stats
    {
        public string SkillName;
        public double Damage;
        public double Penetration;
        public double Heal;
        public double Cost;
        public string Description;

        public Stats(string name, double damage, double penetration, double heal, double cost, string description)
        {
            SkillName = name;
            Damage = damage;
            Penetration = penetration;
            Heal = heal;
            Cost = cost;
            Description = description;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Skill: {SkillName}, Damage: {Damage}, Penetration: {Penetration}, Heal: {Heal}, Cost: {Cost}, Description: {Description}");
        }
    }
}
