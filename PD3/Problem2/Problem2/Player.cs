using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Problem2
{
    internal class Player
    {
        public double hp;
        public double maxHP;
        public double Energy;
        public double maxEnergy;
        public double Armor;
        public string PlayerName;
        Stats skillStatistic;

        public Player(string name, double health, double energy, double armor)
        {
            PlayerName = name;
            hp = health;
            Energy = energy;
            Armor = armor;
            maxHP = hp;
            maxEnergy = energy;
        }

        public void UpdateHealth(double damage, double heal)
        {
            hp -= damage;
            if (hp < 0)
            {
                hp = 0;
            }

            hp += heal;
            if (hp > maxHP)
            {
                hp = maxHP;
            }
        }

        public void UpdateEnergy(double cost)
        {
            Energy -= cost;
            if (Energy < 0)
            {
                Energy = 0;
            }
        }

        public void UpdateArmor(double newArmor)
        {
            Armor = newArmor;
        }

        public void LearnSkill(Stats skill)
        {
            skillStatistic = skill;
        }

        public string Attack(Player attacker,Player target)
        {
            string result;
            if (attacker.Energy < skillStatistic.Cost)
            {
                result = attacker.PlayerName + " attempted to use " + skillStatistic.SkillName + ", but didn't have enough energy!";
            }
            else
            {
                double effectiveArmor = target.Armor - skillStatistic.Penetration;
                if (effectiveArmor < 0)
                {
                    effectiveArmor = 0;
                }

                double damage = skillStatistic.Damage * ((100 - effectiveArmor) / 100);

                if (damage < 0)
                {
                    damage = 0;
                }

                target.UpdateHealth(damage, 0);
                attacker.UpdateHealth(0, skillStatistic.Heal);

                attacker.UpdateEnergy(skillStatistic.Cost);

                result = attacker.PlayerName + " used " + skillStatistic.SkillName + ", " + skillStatistic.Description + ", against " + target.PlayerName + ", doing " + damage + " damage!";

                if (skillStatistic.Heal > 0)
                {
                    result += " " + attacker.PlayerName + " healed for " + skillStatistic.Heal + " health!";
                }

                if (target.hp <= 0)
                {
                    result += " " + target.PlayerName + " died.";
                }
                else
                {
                    double targetHealthPercent = (target.hp / target.maxHP) * 100;
                    result += " " + target.PlayerName + " is at " + targetHealthPercent + "% health.";
                }
            }

            return result;
        }

    }
}
