using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMTool
{
    class Program
    {
        static int index = 0;
        private static void Main(string[] args)
        {
            string race = "";
            bool BreathWeapon = false; 
            string BreathWeaponType = "";
            int Strength = 0;
            int Dexterity = 0;
            int Constitution = 0;
            int Intelligence = 0;
            int Wisdom = 0;
            int Charisma = 0;
            bool raceSelect = false;


            ConsoleApp3.Charater charater = new ConsoleApp3.Charater("René ", "Lassen");
            Console.WriteLine(charater.GetFullname());

            charater.Strength = 17;

            Console.WriteLine(charater.Strength);

            List<string> menuItem = new List<string>()
            {
                "Charater creation",
                "Treasure Generator",
                "Encounter Generator",
                "Monster Creator",
                "Dungen Generator",
                "Exit"
            };
            Console.CursorVisible = false;
            while (true)
            {
                string selectedMenuItem = drawMenu(menuItem);
                if (selectedMenuItem == "Charater creation")
                {
                    Console.Clear();
                    Console.WriteLine("No charater no game!");Console.Read();
                    List<string> raceItem = new List<string>()
                        {
                            "Aarakocra", "Aasimar", "Bugbear",
                            "Centaur", "Dragonborn", "Dwarf",
                            "Elf", "Feral Tiefling", "Firblog",
                            "Genasi", "Gith", "Gnome",
                            "Goblin", "Goliath", "Half-Elf",
                            "Half-Orc", "Hobgoblin", "Human",
                            "Kenku", "Kobold", "Lizardfolk",
                            "Minotaur", "Orc", "Tabaxi",
                            "Tiefling", "Tortle", "Triton",
                            "Yuan-ti Prueblood", "Exit"

                        };
                    Console.CursorVisible = false;

                    while (true)
                    {
                        string selectedRaceItem = drawMenu(raceItem);
                        if (selectedRaceItem == "Aarakocra")
                        {
                            Console.Clear();
                            Dexterity = Dexterity + 2;
                            Wisdom = Wisdom + 1;
                            race = "Aarakocra";
                            break;
                        }
                        else if (selectedRaceItem == "Aasimar")
                        {
                            Console.Clear();
                            Charisma = Charisma + 2;
                            race = "Aasimar";
                            Console.WriteLine("Now you have to pick a subrace");Console.Read();
                            List<string> Aasimar = new List<string>()
                            {
                                "Fallen", "Protector", "Scourge", "Exit"
                            };
                        Console.CursorVisible = false;
                        while (true)
                        {
                                string selectedAasimarItem = drawMenu(Aasimar);
                                if (selectedAasimarItem == "Fallen")
                                {
                                    Console.Clear();
                                    Strength = Strength + 1;
                                    race = "Fallen " + race;
                                    raceSelect = true;

                                    break;
                                }
                                else if (selectedAasimarItem == "Protector")
                                {
                                    Console.Clear();
                                    Wisdom = Wisdom + 1;
                                    race = "Protector ";

                                    break;
                                }
                                else if (selectedAasimarItem == "Scourge")
                                {
                                    Console.Clear();
                                    Constitution = Constitution + 1;
                                    race = "Scourge ";
                                    break;
                                } 
                                else if (selectedAasimarItem == "Exit")
                                {
                                    Console.Clear();
                                    Charisma = 0;
                                    race = "";
                                    break;
                                }
                            }
                            
                        }
                        else if (selectedRaceItem == "Bugbear")
                        {
                            Console.Clear();
                            Strength = Strength + 2;
                            Dexterity = Dexterity + 1;
                            race = "Bugbear";
                            break;
                        }
                        else if (selectedRaceItem == "Dragonborn")
                        {
                            Console.Clear();
                            Strength = Strength + 2;
                            Charisma = Charisma + 1;
                            race = "Dragonborn";
                            Console.WriteLine("Now you have to pick a Draconic Ancestry");
                            List<string> Dragonborn = new List<string>()
                            {
                                "Black (Acid)", "Blue (Lightning)", "Brass (Fire)", 
                                "Bronze (Lightning)", "Copper (Acid)", "Gold (Fire)", 
                                "Green (Poison)", "Red (Fire)", "Silver (Cold)", 
                                "White (Cold)", "Exit"
                            };
                        Console.CursorVisible = false;
                            while (true)
                            {
                                string selectedDragonbornItem = drawMenu(Dragonborn);
                                if (selectedDragonbornItem == "Black (Acid)")
                                {
                                    Console.Clear();
                                    race = "Black " + race;
                                    BreathWeapon = true;
                                    BreathWeaponType = "Acid";
                                    break;
                                }
                                else if (selectedDragonbornItem == "Exit")
                                {
                                    Console.Clear();
                                    Strength = 0;
                                    Charisma = 0;
                                    race = "";

                                    break;
                                }
                            }
                        }
                        else if (selectedRaceItem == "Exit")
                        {
                            Console.Clear();
                            index = 0;
                            break;
                        }
                        
                    }
                    Console.WriteLine("Now you have to pick a Class");
                    List<string> ClassItem = new List<string>()
                    {
                        "Barbarian", "Bard", "Cleric",
                        "Druid", "Fighter", "Monk",
                        "Paladin", "Ranger", "Rogue",
                        "Sorcerer", "Warlock", "Wizard",
                        "Exit"
                    };



                    Console.CursorVisible = false;
                    while (raceSelect == true)
                    {
                        string selectedClassItem = drawMenu(ClassItem);
                        if (selectedClassItem == "Barbarian")
                        {
                            Console.Clear();
                            break;
                        }
                        else if (selectedClassItem == "Exit")
                        {
                            Console.Clear();
                            break;
                        }
                    }


                    


                }
                else if (selectedMenuItem == "Treasure Generator")
                {
                    Console.WriteLine("Adventures wants Treasure");
                }
                else if (selectedMenuItem == "Exit")
                {
                    Environment.Exit(0);
                }
            }
        }

        private static string drawMenu(List<String> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine(items[i]);
                }
                else
                {
                    Console.WriteLine(items[i]);
                }
                Console.ResetColor();
            }

            ConsoleKeyInfo ckey = Console.ReadKey();

            if (ckey.Key == ConsoleKey.DownArrow)
            {
                if (index == items.Count - 1) { index = 0; }
                else { index++; }
            }

            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                if (index <= 0) { index = items.Count - 1; }
                else { index--; }

            }
            else if (ckey.Key == ConsoleKey.Enter)
            {
                return items[index];
            }
            else
            {
                return "";
            }

            Console.Clear();
            return "";
        }
    }
}
