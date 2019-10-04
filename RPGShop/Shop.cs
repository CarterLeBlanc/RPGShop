using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RPGShop
{
    class Shop
    {
        //Initialize variables for later use
        private static string _choice = "";
        private static bool _exit = false;
        private static bool _exit2 = false;

        //Operates as the shop menu and gives the user options
        public static void Menu()
        {
            //Load the previous save if one exists
            if (File.Exists("Shop.txt"))
            {
                Load("Shop.txt");
            }
            //Loop the menu as long as _exit is set to false
            while (!_exit)
            {
                //Options for the user to make
                Console.WriteLine("0: Exit");
                Console.WriteLine("1: Buy");
                Console.WriteLine("2: Sell");
                Console.WriteLine("3: Inspect");
                Console.WriteLine("4: Save");
                Console.WriteLine("5: Load");

                //User's choice is set to whatever they type in
                _choice = Console.ReadLine();

                //If the choice is 0, the program closes
                if (_choice == "0")
                {
                    _exit = true;
                }
                //If choice is 1, call Buy()
                else if (_choice == "1")
                {
                    Buy();
                }
                //If the choice is 2, call Sell()
                else if (_choice == "2")
                {
                    Sell();
                }
                //If choice is 3, call Inspect()
                else if (_choice == "3")
                {
                    Inspect();
                }
                //If choice is 4, call Save()
                else if (_choice == "4")
                {
                    Save("Shop.txt");
                    Console.WriteLine("Game Saved");
                }
                //If choice is 5, call Load()
                else if (_choice == "5")
                {
                    Load("Shop.txt");
                }
                //Secret option that activates the Super User mode by calling SuperUser.AddItems() whenever the user types in "password"
                else if (_choice == "password")
                {
                    SuperUser.AddItems();
                }
                //If none of the previous options, prints an error message
                else
                {
                    Console.WriteLine("Please choose a valid option.");
                }
            }

            void Buy()
            {
                //Loop as long as the user does not input 0
                while (_choice != "0")
                {
                    //Buy menu for the user
                    Console.WriteLine("What would you like to buy?");
                    Console.WriteLine("0: Back");
                    Console.WriteLine("1: Weapons");
                    Console.WriteLine("2: Armour");
                    Console.WriteLine("3: Consumables");

                    //User's choice is set to whatever they type in
                    _choice = Console.ReadLine();

                    //If choice is 1, opens the weapons buy menu in the store inventory
                    if (_choice == "1")
                    {
                        ShopInventory.PrintWeapons();
                    }

                    //If choice is 2, opens the armour buy menu in the store inventory
                    else if (_choice == "2")
                    {
                        ShopInventory.PrintArmour();
                    }

                    //If choice is 3, opens the consumables buy menu in the store inventory
                    else if (_choice == "3")
                    {
                        ShopInventory.PrintConsumables();
                    }

                    //Otherwise, print an error message
                    else if (_choice != "0" && _choice != "1" && _choice != "2" && _choice != "3")
                    {
                        Console.WriteLine("Please choose a valid option.");
                    }
                }
            }

            void Sell()
            {
                //Loop as long as the user does not input 0
                while (_choice != "0")
                {
                    //Sell menu for the user
                    Console.WriteLine("What would you like to sell?");
                    Console.WriteLine("0: Back");
                    Console.WriteLine("1: Weapons");
                    Console.WriteLine("2: Armour");
                    Console.WriteLine("3: Consumables");

                    //User's choice is set to whatever they type in
                    _choice = Console.ReadLine();

                    //If choice is 1, opens the weapons sell menu in the character inventory
                    if (_choice == "1")
                    {
                        CharacterInventory.PrintWeapons();
                    }

                    //If choice is 2, opens the armour sell menu in the character inventory
                    else if (_choice == "2")
                    {
                        CharacterInventory.PrintArmour();
                    }

                    //If choice is 3, opens the consumables sell menu in the character inventory
                    else if (_choice == "3")
                    {
                        CharacterInventory.PrintConsumables();
                    }

                    //Otherwise, print an error message
                    else if (_choice != "0" && _choice != "1" && _choice != "2" && _choice != "3")
                    {
                        Console.WriteLine("Please choose a valid option.");
                    }
                }
            }

            void Inspect()
            {
                _exit2 = false;

                //Loop while _exit2 is set to false
                while (!_exit2)
                {
                    Console.WriteLine("Which inventory would you like to inspect?");
                    Console.WriteLine("0: Back");
                    Console.WriteLine("1: Shop");
                    Console.WriteLine("2: Player");

                    //User's choice is set to whatever they type in
                    _choice = Console.ReadLine();

                    //If choice is 0, set _exit2 to true
                    if (_choice == "0")
                    {
                        _exit2 = true;
                    }

                    //If choice is 1, open the inspect menu for the shop
                    if (_choice == "1")
                    {
                        //Loop as long as the user does not input 0
                        while (_choice != "0")
                        {
                            //Inspect menu for the user
                            Console.WriteLine("What would you like to inspect?");
                            Console.WriteLine("0: Back");
                            Console.WriteLine("1: Weapons");
                            Console.WriteLine("2: Armour");
                            Console.WriteLine("3: Consumables");

                            //User's choice is set to whatever they type in
                            _choice = Console.ReadLine();

                            //If choice is 1, opens the weapons inspect menu in the store inventory
                            if (_choice == "1")
                            {
                                ShopInventory.InspectWeapons();
                            }

                            //If choice is 2, opens the armour inspect menu in the store inventory
                            else if (_choice == "2")
                            {
                                ShopInventory.InspectArmour();
                            }

                            //If choice is 3, opens the consumables inspect menu in the store inventory
                            else if (_choice == "3")
                            {
                                ShopInventory.InspectPotions();
                            }

                            //Otherwise, print an error message
                            else if (_choice != "0" && _choice != "1" && _choice != "2" && _choice != "3")
                            {
                                Console.WriteLine("Please choose a valid option.");
                            }
                        }
                    }

                    //If choice is 2, open the inspect menu for the player
                    else if (_choice == "2")
                    {
                        //Loop as long as the user does not input 0
                        while (_choice != "0")
                        {
                            //Inspect menu for the user
                            Console.WriteLine("What would you like to inspect?");
                            Console.WriteLine("0: Back");
                            Console.WriteLine("1: Weapons");
                            Console.WriteLine("2: Armour");
                            Console.WriteLine("3: Consumables");

                            //User's choice is set to whatever they type in
                            _choice = Console.ReadLine();

                            //If choice is 1, opens the weapons inspect menu in the character inventory
                            if (_choice == "1")
                            {
                                CharacterInventory.InspectWeapons();
                            }

                            //If choice is 2, opens the armour inspect menu in the character inventory
                            else if (_choice == "2")
                            {
                                CharacterInventory.InspectArmour();
                            }

                            //If choice is 3, opens the consumables inspect menu in the character inventory
                            else if (_choice == "3")
                            {
                                CharacterInventory.InspectPotions();
                            }

                            //Otherwise, print an error message
                            else if (_choice != "0" && _choice != "1" && _choice != "2" && _choice != "3")
                            {
                                Console.WriteLine("Please choose a valid option.");
                            }
                        }
                    }
                }

            }

            void Save(string path)
            {
                //Create save file
                StreamWriter writer = File.CreateText(path);

                //Save Gold
                writer.WriteLine(Character.gold);

                //Goes through player weapons and saves them
                writer.WriteLine(CharacterInventory.weapons.Length);
                foreach (Item item in CharacterInventory.weapons)
                {
                    if (item is AttackItem)
                    {
                        AttackItem temp = item as AttackItem;
                        item.GetName();
                        writer.WriteLine("Weapon");
                        writer.WriteLine(item.GetName());
                        writer.WriteLine(item.GetValue());
                        writer.WriteLine(item.GetDescription());
                    }
                }

                //Goes through player's armour and saves them
                writer.WriteLine(CharacterInventory.armour.Length);
                foreach (Item item in CharacterInventory.armour)
                {
                    if (item is DefenseItem)
                    {
                        DefenseItem temp = item as DefenseItem;
                        item.GetName();
                        writer.WriteLine("Armour");
                        writer.WriteLine(item.GetName());
                        writer.WriteLine(item.GetValue());
                        writer.WriteLine(item.GetDescription());
                    }
                }

                //Goes through player's consumables and saves them
                writer.WriteLine(CharacterInventory.potions.Length);
                foreach (Item item in CharacterInventory.potions)
                {
                    if (item is Consumables)
                    {
                        Consumables temp = item as Consumables;
                        item.GetName();
                        writer.WriteLine("Potion");
                        writer.WriteLine(item.GetName());
                        writer.WriteLine(item.GetValue());
                        writer.WriteLine(item.GetDescription());
                    }
                }

                //Goes through shop weapons and saves them
                writer.WriteLine(ShopInventory.weapons.Length);
                foreach (Item item in ShopInventory.weapons)
                {
                    if (item is AttackItem)
                    {
                        AttackItem temp = item as AttackItem;
                        item.GetName();
                        writer.WriteLine("Weapon");
                        writer.WriteLine(item.GetName());
                        writer.WriteLine(item.GetValue());
                        writer.WriteLine(item.GetDescription());
                    }
                }

                //Goes through shop's armour and saves them
                writer.WriteLine(ShopInventory.armour.Length);
                foreach (Item item in ShopInventory.armour)
                {
                    if (item is DefenseItem)
                    {
                        DefenseItem temp = item as DefenseItem;
                        item.GetName();
                        writer.WriteLine("Armour");
                        writer.WriteLine(item.GetName());
                        writer.WriteLine(item.GetValue());
                        writer.WriteLine(item.GetDescription());
                    }
                }

                //Goes through shop's consumables and saves them
                writer.WriteLine(ShopInventory.potions.Length);
                foreach (Item item in ShopInventory.potions)
                {
                    if (item is Consumables)
                    {
                        Consumables temp = item as Consumables;
                        item.GetName();
                        writer.WriteLine("Potion");
                        writer.WriteLine(item.GetName());
                        writer.WriteLine(item.GetValue());
                        writer.WriteLine(item.GetDescription());
                    }
                }

                writer.Close();
            }

            //Loads a previous save
            void Load(string path)
            {
                //Checks if a save file exists
                if (File.Exists("Shop.txt"))
                {
                    //Load text file
                    StreamReader reader = File.OpenText(path);
                    //Load player gold
                    Character.gold = Convert.ToInt32(reader.ReadLine());

                    //Clears weapons in the player's inventory
                    for (int i = 0; i < CharacterInventory.weapons.Length; i++)
                    {
                        CharacterInventory.RemoveWeapon(i);
                        i--;
                    }

                    //Clears armour in the player's inventory
                    for (int i = 0; i < CharacterInventory.armour.Length; i++)
                    {
                        CharacterInventory.RemoveArmour(i);
                        i--;
                    }

                    //Clears consumables in the player's inventory
                    for (int i = 0; i < CharacterInventory.potions.Length; i++)
                    {
                        CharacterInventory.RemovePotion(i);
                        i--;
                    }

                    //Clears weapons in the shop inventory
                    for (int i = 0; i < ShopInventory.weapons.Length; i++)
                    {
                        ShopInventory.RemoveWeapon(i);
                        i--;
                    }

                    //Clears armour in the shop inventory
                    for (int i = 0; i < ShopInventory.armour.Length; i++)
                    {
                        ShopInventory.RemoveArmour(i);
                        i--;
                    }

                    //Clears consumables in the shop inventory
                    for (int i = 0; i < ShopInventory.potions.Length; i++)
                    {
                        ShopInventory.RemovePotion(i);
                        i--;
                    }

                    int temp = Convert.ToInt32(reader.ReadLine());

                    //Adds items to player's inventory
                    for (int i = 0; i < temp; i++)
                    {
                        string type = "";
                        string name = "";
                        int cost = 0;
                        string description = "";

                        type = reader.ReadLine();

                        //If item is a weapon, add it to the weapon inventory
                        if (type == "Weapon")
                        {
                            name = reader.ReadLine();
                            cost = Convert.ToInt32(reader.ReadLine());
                            description = reader.ReadLine();

                            CharacterInventory.AddWeapon(new AttackItem(name, cost, description));
                        }
                    }

                    int temp2 = Convert.ToInt32(reader.ReadLine());

                    for (int i = 0; i < temp2; i++)
                    {
                        string type = "";
                        string name = "";
                        int cost = 0;
                        string description = "";

                        type = reader.ReadLine();

                        //If item is armour, add it to the armour inventory
                        if (type == "Armour")
                        {
                            name = reader.ReadLine();
                            cost = Convert.ToInt32(reader.ReadLine());
                            description = reader.ReadLine();

                            CharacterInventory.AddArmour(new DefenseItem(name, cost, description));
                        }
                    }

                    int temp3 = Convert.ToInt32(reader.ReadLine());

                    for (int i = 0; i < temp3; i++)
                    {
                        string type = "";
                        string name = "";
                        int cost = 0;
                        string description = "";

                        type = reader.ReadLine();

                        //If item is a concumable, add it to the consumable inventory
                        if (type == "Potion")
                        {
                            name = reader.ReadLine();
                            cost = Convert.ToInt32(reader.ReadLine());
                            description = reader.ReadLine();

                            CharacterInventory.AddPotion(new Consumables(name, cost, description));
                        }
                    }

                    //Adds items to the shop inventory
                    int temp4 = Convert.ToInt32(reader.ReadLine());

                    for (int i = 0; i < temp4; i++)
                    {
                        string type = "";
                        string name = "";
                        int cost = 0;
                        string description = "";

                        type = reader.ReadLine();

                        //If item is a weapon, add it to the weapon inventory
                        if (type == "Weapon")
                        {
                            name = reader.ReadLine();
                            cost = Convert.ToInt32(reader.ReadLine());
                            description = reader.ReadLine();

                            ShopInventory.AddWeapon(new AttackItem(name, cost, description));
                        }
                    }

                    int temp5 = Convert.ToInt32(reader.ReadLine());

                    for (int i = 0; i < temp5; i++)
                    {
                        string type = "";
                        string name = "";
                        int cost = 0;
                        string description = "";

                        type = reader.ReadLine();

                        //If item is armour, add it to the armour inventory
                        if (type == "Armour")
                        {
                            name = reader.ReadLine();
                            cost = Convert.ToInt32(reader.ReadLine());
                            description = reader.ReadLine();

                            ShopInventory.AddArmour(new DefenseItem(name, cost, description));
                        }
                    }

                    int temp6 = Convert.ToInt32(reader.ReadLine());

                    for (int i = 0; i < temp6; i++)
                    {
                        string type = "";
                        string name = "";
                        int cost = 0;
                        string description = "";

                        type = reader.ReadLine();

                        //If item is a concumable, add it to the consumable inventory
                        if (type == "Potion")
                        {
                            name = reader.ReadLine();
                            cost = Convert.ToInt32(reader.ReadLine());
                            description = reader.ReadLine();

                            ShopInventory.AddPotion(new Consumables(name, cost, description));
                        }
                    }
                    reader.Close();
                    Console.WriteLine("Save file loaded.");
                }

                //Print a message if a save file does not exist
                else
                {
                    Console.WriteLine("Save file does not exist.");
                }
            }
        }
    }
}
