using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    internal class Player
    {
        public string PlayerName;
        public double hp;
        public double maxHP;
        public double Energy;
        public double maxEnergy;
        public double Armor;
        public List<Stats> skillStatistics;

        public Player(string name, double health, double energy, double armor)
        {
            PlayerName = name;
            hp = health;
            maxHP = health;
            Energy = energy;
            maxEnergy = energy;
            Armor = armor;
            skillStatistics = new List<Stats>();
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

        public void LearnSkill(Stats skill)
        {
            skillStatistics.Add(skill); 
            Console.WriteLine(PlayerName + " learned the skill: " + skill.SkillName + " successfully.");
        }

        public List<Stats> GetLearnedSkills()
        {
            return skillStatistics;
        }

        public string Attack(Player target,Stats skillToUse)
        {
            string result;
            if (skillToUse == null)
            {
                result = PlayerName + " hasn't learned any skill yet!";
            }
            else
            {
                if (Energy < skillToUse.Cost)
                {
                    result = PlayerName + " attempted to use " + skillToUse.SkillName + ", but didn't have enough energy!";
                }
                else
                {
                    double effectiveArmor = target.Armor - skillToUse.Penetration;
                    if (effectiveArmor < 0)
                    {
                        effectiveArmor = 0;
                    }

                    double damage = skillToUse.Damage * ((100 - effectiveArmor) / 100);
                    if (damage < 0)
                    {
                        damage = 0;
                    }

                    target.UpdateHealth(damage, 0);
                    UpdateHealth(0, skillToUse.Heal);
                    UpdateEnergy(skillToUse.Cost);

                    result = PlayerName + " used " + skillToUse.SkillName + ", " + skillToUse.Description + ", against " + target.PlayerName + ", doing " + damage + " damage!";

                    if (skillToUse.Heal > 0)
                    {
                        result += " " + PlayerName + " healed for " + skillToUse.Heal + " health!";
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
            }

            return result;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Player: " + PlayerName + ", Health: " + ((hp/maxHP)*100) + ", Energy: " + ((Energy/maxEnergy)*100) + ", Armor: " + Armor);
            if (skillStatistics.Count == 0)
            {
                Console.WriteLine("No skills learned.");
            }
            else
            {
                Console.WriteLine("Learned Skills:");
                foreach (var skill in skillStatistics)
                {
                    Console.WriteLine("->" + skill.SkillName + ": " + skill.Description);
                }
            }
        }
    }
}
