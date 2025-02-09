using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    internal class Stats
    {
        public string SkillName;
        public double Damage;
        public string Description;
        public double Penetration;
        public double Cost;
        public double Heal;

        public Stats(string name, double damage, double penetration, double heal, double cost, string description)
        {
            SkillName = name;
            Damage = damage;
            Penetration = penetration;
            Heal = heal;
            Cost = cost;
            Description = description;
        }
    }
}
