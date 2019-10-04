using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prints a welcome message for the user
            Console.WriteLine("Welcome to the shop traveller. What would you like to do?");

            //Opens the shop menu
            Shop.Menu();
        }
    }
}
