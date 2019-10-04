using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGShop
{
    class CharacterInventory
    {
        private static string _choice = "";
        private static int _choice2;
        private static bool _exit = false;

        Item item = new Item();

        //Weapons
        private static Item stick = new AttackItem("Stick", 1, "A sturdy tree branch.");

        //Armour
        private static Item clothes = new DefenseItem("Clothes", 1, "Just normal clothes. Nothing Special.");

        //Inventories
        public static Item[] weapons = { stick };
        public static Item[] armour = { clothes };
        public static Item[] potions = { };

        //Prints and conducts the sell function for the player's weapon inventory
        public static void PrintWeapons()
        {
            _exit = false;

            //Loops while _exit is set to false
            while (!_exit)
            {
                //Checks if the player has any weapons to sell in the first place
                if (weapons.Length <= 0)
                {
                    Console.WriteLine("You do not have any weapons.");
                    _exit = true;
                }

                //If they have weapons, continue on with the option of what to sell
                else
                {
                    Console.WriteLine("0: Back");

                    //Prints the weapon array for the player's inventory
                    for (int i = 0; i < weapons.Length; i++)
                    {
                        Console.WriteLine(i + 1 + ":" + weapons[i].GetName() + " Cost: " + weapons[i].GetValue() + " Gold");
                    }

                    _choice = Console.ReadLine();

                    //If the user inputs 0, exit the loop and go back to the previous menu
                    if (_choice == "0")
                    {
                        _exit = true;
                    }

                    //If the user's choice is one of these numbers, sell whatever weapon applies to their choice
                    else if (_choice == "1" || _choice == "2" || _choice == "3" ||
                             _choice == "4" || _choice == "5" || _choice == "6" ||
                             _choice == "7" || _choice == "8" || _choice == "9")
                    {
                        for (int i = 0; i < weapons.Length; i++)
                        {
                            _choice2 = Convert.ToInt32(_choice);

                            if (_choice2 == i + 1)
                            {
                                Console.WriteLine("Sold " + weapons[i].GetName());
                                Character.gold += weapons[i].GetValue();
                                ShopInventory.AddWeapon(weapons[i]);
                                RemoveWeapon(i);
                                Console.WriteLine("");
                                Console.WriteLine("You now have " + Character.gold + " gold.");
                                Console.WriteLine("");
                            }
                        }
                        _exit = true;
                    }

                    //If the user's input is not any of the previous options, print an error message
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
                    Console.WriteLine("You do not have any armour");
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
                                Console.WriteLine("Sold " + armour[i].GetName());
                                Character.gold += armour[i].GetValue();
                                ShopInventory.AddArmour(armour[i]);
                                RemoveArmour(i);
                                Console.WriteLine("");
                                Console.WriteLine("You now have " + Character.gold + " gold.");
                                Console.WriteLine("");
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
                    Console.WriteLine("You do not have any potions.");
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
                                Console.WriteLine("Sold " + potions[i].GetName());
                                Character.gold += potions[i].GetValue();
                                ShopInventory.AddPotion(potions[i]);
                                RemovePotion(i);
                                Console.WriteLine("");
                                Console.WriteLine("You now have " + Character.gold + " gold.");
                                Console.WriteLine("");
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
                    Console.WriteLine("You do not have any weapons.");
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
                    Console.WriteLine("You have no armour.");
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
                    Console.WriteLine("You do not have any potions.");
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
