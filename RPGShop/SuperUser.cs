using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGShop
{
    class SuperUser
    {
        protected static string newItemName;
        protected static int newItemValue = 0;
        protected static string newItemDescription;
        protected static string _choice = "";
        protected static bool exit = false;

        Item item = new Item();

        public static void AddItems()
        {
            Console.WriteLine("Super User mode activated");
            Console.WriteLine("");

            Console.WriteLine("Enter a name for the new item");
            newItemName = Console.ReadLine();

            while (newItemValue == 0)
            {
            Console.WriteLine("Enter a value for the new item");
            Int32.TryParse(Console.ReadLine(), out newItemValue);
            }

            Console.WriteLine("Enter a description for the new item");
            newItemDescription = Console.ReadLine();


            Console.WriteLine("New item created");
            Console.WriteLine("");
            Console.WriteLine("Item Name: " + newItemName);
            Console.WriteLine("Item Value: " + newItemValue);
            Console.WriteLine("Item Description: " + newItemDescription);
            Console.WriteLine("");

            while (!exit)
            {
                Console.WriteLine("What kind of item is this?");
                Console.WriteLine("1: Attack");
                Console.WriteLine("2: Defense");
                Console.WriteLine("3: Consumable");

                _choice = Console.ReadLine();

                if (_choice == "1")
                {
                    Item newItem = new AttackItem(newItemName, newItemValue, newItemDescription);
                    ShopInventory.AddWeapon(newItem);
                    Console.WriteLine(newItem.GetName() + " has been added to the shop.");
                    exit = true;
                }

                else if (_choice == "2")
                {
                    Item newItem = new DefenseItem(newItemName, newItemValue, newItemDescription);
                    ShopInventory.AddArmour(newItem);
                    Console.WriteLine(newItem.GetName() + " has been added to the shop.");
                    exit = true;
                }

                else if (_choice == "3")
                {
                    Item newItem = new Consumables(newItemName, newItemValue, newItemDescription);
                    ShopInventory.AddPotion(newItem);
                    Console.WriteLine(newItem.GetName() + " has been added to the shop.");
                    exit = true;
                }

                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Please choose a valid option.");
                    Console.WriteLine("");
                }
            }
        }
    }
}
