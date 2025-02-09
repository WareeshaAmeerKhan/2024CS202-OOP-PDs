using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    internal class Program
    {
        static List<Player> players = new List<Player>()
                                                        {
                                                            new Player("Alice", 100, 50, 20),
                                                            new Player("Bob", 100, 50, 30)
                                                        };
        static List<Stats> skills = new List<Stats>()
                                                        {
                                                            new Stats("Fireball", 50, 10, 0, 20, "A fiery attack with armor penetration."),
                                                            new Stats("Heal", 0, 0, 30, 10, "A healing skill.")
                                                        };


        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("~:MAGIC DUEL MENU:~");
                Console.WriteLine();
                Console.WriteLine("1. Add Player");
                Console.WriteLine("2. Add Skill Statistics");
                Console.WriteLine("3. Display Player Info");
                Console.WriteLine("4. Learn a Skill");
                Console.WriteLine("5. Attack");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");

                int choice;
                choice = int.Parse(Console.ReadLine());
                if (choice > 6 || choice < 1)
                {
                    Console.WriteLine("Invalid choice. Please enter again.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddPlayer();
                        break;
                    case 2:
                        AddSkill();
                        break;
                    case 3:
                        DisplayPlayers();
                        break;
                    case 4:
                        LearnSkill();
                        break;
                    case 5:
                        Attack();
                        break;
                    case 6:
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        static void AddPlayer()
        {
            Console.Write("Enter Player Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Health: ");
            double health = double.Parse(Console.ReadLine());
            Console.Write("Enter Energy: ");
            double energy = double.Parse(Console.ReadLine());
            Console.Write("Enter Armor: ");
            double armor = double.Parse(Console.ReadLine());

            players.Add(new Player(name, health, energy, armor));
            Console.WriteLine("Player added successfully!");
        }

        static void AddSkill()
        {
            Console.Write("Enter Skill Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Damage: ");
            double damage = double.Parse(Console.ReadLine());
            Console.Write("Enter Penetration: ");
            double penetration = double.Parse(Console.ReadLine());
            Console.Write("Enter Heal: ");
            double heal = double.Parse(Console.ReadLine());
            Console.Write("Enter Energy Cost: ");
            double cost = double.Parse(Console.ReadLine());
            Console.Write("Enter Skill Description: ");
            string description = Console.ReadLine();

            skills.Add(new Stats(name, damage, penetration, heal, cost, description));
            Console.WriteLine("Skill added successfully!");
        }

        static void DisplayPlayers()
        {
            if (players.Count == 0)
            {
                Console.WriteLine("No players available.");
                return;
            }

            foreach (var player in players)
            {
                Console.WriteLine("Name: " + player.PlayerName + ", Health: " + (player.hp / player.maxHP * 100) + "%" + ", Energy: " + (player.Energy / player.maxEnergy * 100) + "%" + ", Armor: " + player.Armor);

                if (player.GetLearnedSkills().Count == 0)
                {
                    Console.WriteLine("  Learned Skills: None");
                }
                else
                {
                    Console.WriteLine("  Learned Skills:");
                    int i = 0;
                    foreach (var skill in player.GetLearnedSkills())
                    {
                        i++;
                        Console.WriteLine("              " + i + ") " + skill.SkillName + ": " + skill.Description);
                    }
                }
            }
        }


        static void LearnSkill()
        {
            Console.Write("Enter Player Name: ");
            string playerName = Console.ReadLine();

            Player player = players.Find(p => p.PlayerName == playerName);
            if (player == null)
            {
                Console.WriteLine("Player not found.");
                return;
            }

            Console.WriteLine("Available Skills: ");
            for (int i = 0; i < skills.Count; i++)
            {
                int j = i + 1;
                Console.WriteLine(j + ")" + skills[i].SkillName);
            }

            Console.Write("Enter the number of the skill to learn: ");
            int skillChoice = int.Parse(Console.ReadLine()) - 1;

            if (skillChoice < 0 || skillChoice >= skills.Count)
            {
                Console.WriteLine("Invalid skill choice.");
                return;
            }

            Stats skill = skills[skillChoice];
            player.LearnSkill(skill);
        }

        static void Attack()
        {
            Console.Write("Enter Attacker Name: ");
            string attackerName = Console.ReadLine();

            Player attacker = players.Find(p => p.PlayerName == attackerName);
            if (attacker == null)
            {
                Console.WriteLine("Attacker not found.");
                return;
            }

            Console.Write("Enter Target Name: ");
            string targetName = Console.ReadLine();

            Player target = players.Find(p => p.PlayerName == targetName);
            if (target == null)
            {
                Console.WriteLine("Target not found.");
                return;
            }

            Console.WriteLine("Available Skills:");
            for (int i = 0; i < attacker.skillStatistics.Count; i++)
            {
                int j = i + 1;
                Console.WriteLine(j + ")" + attacker.skillStatistics[i].SkillName);
            }

            Console.Write("Enter the number of the skill to use: ");
            int skillChoice = int.Parse(Console.ReadLine()) - 1;

            if (skillChoice < 0 || skillChoice >= attacker.skillStatistics.Count)
            {
                Console.WriteLine("Invalid skill choice.");
                return;
            }

            Stats skill = attacker.skillStatistics[skillChoice];
            string result = attacker.Attack(target, skill);
            Console.WriteLine(result);
        }
    }
}
