﻿using System;

namespace Ex1Lab05
{
    class OrderTest
    {
        static void Main(string[] args)
        {
            string choice;
            Console.WriteLine("What would you like to order? 1-Grocery Items, 2-Bakery Item");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                Grocery_items objGrocery = new Grocery_items();
                objGrocery.Ord_grocery();
            }
            else
            {
                if (choice == "2")
                {
                    Bakery_items objBakery = new Bakery_items();
                    objBakery.Ord_bakery();
                }
                else
                {
                    Console.WriteLine("Enter either 1 or 2");
                }
            }
            Console.ReadLine();
        }
    }
}
