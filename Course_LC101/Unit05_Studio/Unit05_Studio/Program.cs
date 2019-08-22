using System;
using System.Collections.Generic;

namespace Unit05_Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            //create two menus to work with
            Menu FirstMenu = new Menu("First Menu");
            Menu SecondMenu = new Menu("SECOND MENU");

            //create some items to work with
            //can i create these somewhere else and still use them here? probably
            MenuItem IceCream = new MenuItem(new DateTime(2019, 08, 01), "Ice Cream", 3.99, "Dessert");
            MenuItem ChickenFriedSteak = new MenuItem(new DateTime(2019, 08, 02), "Chicken Fried Steak", 11.99, "Main Course");
            MenuItem Nachos = new MenuItem(new DateTime(2019, 08, 03), "Nachos", 7.99, "Appetizer");

            //add items to the first menu
            FirstMenu.ItemList.Add(1, IceCream);
            FirstMenu.ItemList.Add(2, ChickenFriedSteak);

            //add items to the second menu
            SecondMenu.ItemList.Add(1, Nachos);

            //display the First menu and its items
            Console.WriteLine(FirstMenu.MenuName + " | " + FirstMenu.MenuDate);
            foreach (KeyValuePair<int, MenuItem> item in FirstMenu.ItemList)
            {
                //this should really be a method, probably in the Menu class, but I can't quite get that to work the way i want it to
                String status = "Not New";
                if (FirstMenu.MenuDate < item.Value.ItemDate) { status = "NEW!!!!"; }
                Console.WriteLine("   >>> " + item.Value.ItemDescription + " | " + item.Value.ItemPrice + " | " + item.Value.ItemCategory + " | Added " + item.Value.ItemDate + " " + status);
            }

            Console.WriteLine("-------------------------------------------------");

            //display the second menu and its items
            Console.WriteLine(SecondMenu.MenuName +" | " + SecondMenu.MenuDate);
            foreach (KeyValuePair<int, MenuItem> items in SecondMenu.ItemList)
            {
                Console.WriteLine("   >>> " + items.Value.ItemDescription + " | " + items.Value.ItemPrice + " | " + items.Value.ItemCategory + " | Added " + items.Value.ItemDate);
            }
        }
    }
}
