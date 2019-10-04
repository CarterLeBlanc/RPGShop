using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGShop
{
    class ShopInventory
    {
        private static string _choice = "";
        private static int _choice2;
        private static bool _exit = false;

        Item item  = new Item();

        //Weapons
        private static Item dagger = new AttackItem("Dagger", 5, "A small simple blade. Not the most effective, but it will still do some damage.");
        private static Item broadsword = new AttackItem("Broadsword", 10, "A trusty sword. Not the best to use, but it will definitely get the job done.");
        private static Item warhammer = new AttackItem("Warhammer", 20, "A heavy blunt hammer used for combat. You can tell that it could do some real damage if wielded correctly.");
        private static Item battleAxe = new AttackItem("Battleaxe", 30, "A very large, double-sided axe. Clearly meant for more than just cutting down trees.");
        private static Item claymore = new AttackItem("Claymore", 40, "An extremely large sword. Takes a lot of skill to use, but very effective if wielded correctly.");

        //Armour
        private static Item leather = new DefenseItem("Leather Armour", 5, "Very light armour. However, does not provide much defense.");
        private static Item studdedLeather = new DefenseItem("Studded Leather Armour", 10, "Light like leather armour, but with slightly more defense.");
        private static Item chainmail = new DefenseItem("Chainmail", 20, "Armour made out of a series of small chains linked together. Provides a decent amount of defense.");
        private static Item plate = new DefenseItem("Plate Armour", 30, "Solid metal armour. Very sturdy with good defense.");
        private static Item scale = new DefenseItem("Scale Armour", 40, "Armour made out of layered pieces of metal. Excellent defense.");

        //Potions
        private static Item health = new Consumables("Health Potion", 5, "Restores a small amount of health.");
        private static Item energy = new Consumables("Energy Potion", 5, "Restores a small amount of energy.");
        private static Item greaterHealth = new Consumables("Greater Health Potion", 10, "Restores a large amount of health.");
        private static Item greaterEnergy = new Consumables("Greater Energy Potion", 10, "Restores a large amount of energy.");
        private static Item strength = new Consumables("Strength Potion", 10, "Increases the user's strength.");

        //Inventories
        public static Item[] weapons = { dagger, broadsword, warhammer, battleAxe, claymore };
        public static Item[] armour = { leather, studdedLeather, chainmail, plate, scale };
        public static Item[] potions = { health, energy, greaterHealth, greaterEnergy, strength };

        public static void PrintWeapons()
        {
            _exit = false;

            while (!_exit)
            {
                if (weapons.Length <= 0)
                {
                    Console.WriteLine("There are no weapons left.");
                    _exit = true;
                }

                else if (CharacterInventory.weapons.Length >= 5)
                {
                    Console.WriteLine("Your inventory is too full to buy anything.");
                    _exit = true;
                }

                else
                {
                    Console.WriteLine("0: Back");
                    for (int i = 0; i < weapons.Length; i++)
                    {
                        Console.WriteLine(i + 1 + ":" + weapons[i].GetName() + " Cost: " + weapons[i].GetValue() + " Gold");
                    }

                    _choice = Console.ReadLine();

                    if (_choice == "0")
                    {
                        _exit = true;
                    }

                    else if (_choice == "1" || _choice == "2" || _choice == "3" ||
                             _choice == "4" || _choice == "5" || _choice == "6" ||
                             _choice == "7" || _choice == "8" || _choice == "9")
                    {
                        for (int i = 0; i < weapons.Length; i++)
                        {
                            _choice2 = Convert.ToInt32(_choice);

                            if (_choice2 == i + 1)
                            {
                                if (Character.GetGold() >= weapons[i].GetValue())
                                {
                                    Console.WriteLine("Purchased " + weapons[i].GetName());
                                    Character.gold -= weapons[i].GetValue();
                                    CharacterInventory.AddWeapon(weapons[i]);
                                    RemoveWeapon(i);
                                    Console.WriteLine("");
                                    Console.WriteLine("You now have " + Character.gold + " gold left.");
                                    Console.WriteLine("");
                                }
                            }
                        }
                        _exit = true;
                    }

                    else
                    {
                        Console.WriteLine("Please choose a valid option.");
                    }
                }
            }
        }

        public static void PrintArmour()
        {
            _exit = false;

            while (!_exit)
            {
                if (armour.Length <= 0)
                {
                    Console.WriteLine("There is no armour left.");
                    _exit = true;
                }

                else if (CharacterInventory.armour.Length >= 5)
                {
                    Console.WriteLine("Your inventory is too full to buy anything.");
                    _exit = true;
                }

                else
                {
                    Console.WriteLine("0: Back");

                    for (int i = 0; i < armour.Length; i++)
                    {
                        Console.WriteLine(i + 1 + ":" + armour[i].GetName() + " Cost: " + armour[i].GetValue() + " Gold");
                    }

                    _choice = Console.ReadLine();

                    if (_choice == "0")
                    {
                        _exit = true;
                    }

                    else if (_choice == "1" || _choice == "2" || _choice == "3" ||
                             _choice == "4" || _choice == "5" || _choice == "6" ||
                             _choice == "7" || _choice == "8" || _choice == "9")
                    {
                        for (int i = 0; i < armour.Length; i++)
                        {
                            _choice2 = Convert.ToInt32(_choice);

                            if (_choice2 == i + 1)
                            {
                                if (Character.GetGold() >= armour[i].GetValue())
                                {
                                    Console.WriteLine("Purchased " + armour[i].GetName());
                                    Character.gold -= armour[i].GetValue();
                                    CharacterInventory.AddArmour(armour[i]);
                                    RemoveArmour(i);
                                    Console.WriteLine("");
                                    Console.WriteLine("You now have " + Character.gold + " gold left.");
                                    Console.WriteLine("");
                                }
                            }
                        }
                        _exit = true;
                    }

                    else
                    {
                        Console.WriteLine("Please choose a valid option.");
                    }
                }
            }
        }

        public static void PrintConsumables()
        {
            _exit = false;

            while (!_exit)
            {
                if (potions.Length <= 0)
                {
                    Console.WriteLine("There are no more potions left.");
                    _exit = true;
                }

                else if (CharacterInventory.potions.Length >= 5)
                {
                    Console.WriteLine("Your inventory is too full to buy anything.");
                    _exit = true;
                }

                else
                {
                    Console.WriteLine("0: Back");

                    for (int i = 0; i < potions.Length; i++)
                    {
                        Console.WriteLine(i + 1 + ":" + potions[i].GetName() + " Cost: " + potions[i].GetValue() + " Gold");
                    }

                    _choice = Console.ReadLine();

                    if (_choice == "0")
                    {
                        _exit = true;
                    }

                    else if (_choice == "1" || _choice == "2" || _choice == "3" ||
                             _choice == "4" || _choice == "5" || _choice == "6" ||
                             _choice == "7" || _choice == "8" || _choice == "9")
                    {
                        for (int i = 0; i < potions.Length; i++)
                        {
                            _choice2 = Convert.ToInt32(_choice);

                            if (_choice2 == i + 1)
                            {
                                if (Character.GetGold() >= potions[i].GetValue())
                                {
                                    Console.WriteLine("Purchased " + potions[i].GetName());
                                    Character.gold -= potions[i].GetValue();
                                    CharacterInventory.AddPotion(potions[i]);
                                    RemovePotion(i);
                                    Console.WriteLine("");
                                    Console.WriteLine("You now have " + Character.gold + " gold left.");
                                    Console.WriteLine("");
                                }
                            }
                        }
                        _exit = true;
                    }

                    else
                    {
                        Console.WriteLine("Please choose a valid option.");
                    }
                }

            }
        }

        public static void AddWeapon(Item value)
        {
            Item[] newWeaponList = new Item[weapons.Length + 1];

            for (int i = 0; i < weapons.Length; i++)
            {
                newWeaponList[i] = weapons[i];
            }

            newWeaponList[newWeaponList.Length - 1] = value;
            weapons = newWeaponList;
        }

        public static void AddArmour(Item value)
        {
            Item[] newArmourList = new Item[armour.Length + 1];

            for (int i = 0; i < armour.Length; i++)
            {
                newArmourList[i] = armour[i];
            }

            newArmourList[newArmourList.Length - 1] = value;
            armour = newArmourList;
        }

        public static void AddPotion(Item value)
        {
            Item[] newPotionList = new Item[potions.Length + 1];

            for (int i = 0; i < potions.Length; i++)
            {
                newPotionList[i] = potions[i];
            }

            newPotionList[newPotionList.Length - 1] = value;
            potions = newPotionList;
        }

        public static Item[] RemoveWeapon(int index)
        {
            Item[] newWeaponList = new Item[weapons.Length - 1];
            int pos = 0;
            
            for (int i = 0; i < weapons.Length; i++)
            {
                if (i != index)
                {
                    newWeaponList[pos] = weapons[i];
                    pos++;
                }
            }
            weapons = newWeaponList;
            return weapons;
        }

        public static Item[] RemoveArmour(int index)
        {
            Item[] newArmourList = new Item[armour.Length - 1];
            int pos = 0;

            for (int i = 0; i < armour.Length; i++)
            {
                if (i != index)
                {
                    newArmourList[pos] = armour[i];
                    pos++;
                }
            }
            armour = newArmourList;
            return armour;
        }

        public static Item[] RemovePotion(int index)
        {
            Item[] newPotionList = new Item[potions.Length - 1];
            int pos = 0;

            for (int i = 0; i < potions.Length; i++)
            {
                if (i != index)
                {
                    newPotionList[pos] = potions[i];
                    pos++;
                }
            }
            potions = newPotionList;
            return potions;
        }

        public static void InspectWeapons()
        {
            _exit = false;

            while (!_exit)
            {
                if (weapons.Length <= 0)
                {
                    Console.WriteLine("There are no weapons left.");
                    _exit = true;
                }

                else
                {
                    Console.WriteLine("Which would you like to inspect?");
                    Console.WriteLine("0: Back");
                    for (int i = 0; i < weapons.Length; i++)
                    {
                        Console.WriteLine(i + 1 + ":" + weapons[i].GetName());
                    }

                    _choice = Console.ReadLine();

                    if (_choice == "0")
                    {
                        _exit = true;
                    }

                    else if (_choice == "1" || _choice == "2" || _choice == "3" ||
                             _choice == "4" || _choice == "5" || _choice == "6" ||
                             _choice == "7" || _choice == "8" || _choice == "9")
                    {
                        for (int i = 0; i < weapons.Length; i++)
                        {
                            _choice2 = Convert.ToInt32(_choice);

                            if (_choice2 == i + 1)
                            {
                                Console.WriteLine(weapons[i].GetDescription());
                            }
                        }
                        _exit = true;
                    }

                    else
                    {
                        Console.WriteLine("Please choose a valid option.");
                    }
                }
            }
        }

        public static void InspectArmour()
        {
            _exit = false;

            while (!_exit)
            {
                if (armour.Length <= 0)
                {
                    Console.WriteLine("There is no armour left.");
                    _exit = true;
                }

                else
                {
                    Console.WriteLine("Which would you like to inspect?");
                    Console.WriteLine("0: Back");
                    for (int i = 0; i < armour.Length; i++)
                    {
                        Console.WriteLine(i + 1 + ":" + armour[i].GetName());
                    }

                    _choice = Console.ReadLine();

                    if (_choice == "0")
                    {
                        _exit = true;
                    }

                    else if (_choice == "1" || _choice == "2" || _choice == "3" ||
                             _choice == "4" || _choice == "5" || _choice == "6" ||
                             _choice == "7" || _choice == "8" || _choice == "9")
                    {
                        for (int i = 0; i < armour.Length; i++)
                        {
                            _choice2 = Convert.ToInt32(_choice);

                            if (_choice2 == i + 1)
                            {
                                Console.WriteLine(armour[i].GetDescription());
                            }
                        }
                        _exit = true;
                    }

                    else
                    {
                        Console.WriteLine("Please choose a valid option.");
                    }
                }
            }
        }

        public static void InspectPotions()
        {
            _exit = false;

            while (!_exit)
            {
                if (potions.Length <= 0)
                {
                    Console.WriteLine("There are no potions left.");
                    _exit = true;
                }

                else
                {
                    Console.WriteLine("Which would you like to inspect?");
                    Console.WriteLine("0: Back");
                    for (int i = 0; i < potions.Length; i++)
                    {
                        Console.WriteLine(i + 1 + ":" + potions[i].GetName());
                    }

                    _choice = Console.ReadLine();

                    if (_choice == "0")
                    {
                        _exit = true;
                    }

                    else if (_choice == "1" || _choice == "2" || _choice == "3" ||
                             _choice == "4" || _choice == "5" || _choice == "6" ||
                             _choice == "7" || _choice == "8" || _choice == "9")
                    {
                        for (int i = 0; i < potions.Length; i++)
                        {
                            _choice2 = Convert.ToInt32(_choice);

                            if (_choice2 == i + 1)
                            {
                                Console.WriteLine(potions[i].GetDescription());
                            }
                        }
                        _exit = true;
                    }

                    else
                    {
                        Console.WriteLine("Please choose a valid option.");
                    }
                }
            }
        }
    }
}
