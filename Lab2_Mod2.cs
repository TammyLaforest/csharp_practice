﻿using System;

namespace Lab2_Mod2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your selection: ");
            string str = Console.ReadLine();
            int cost = 0;

            switch (str)
            {

                case "1":
                case "small":
                    cost += 25;
                    break;
                case "2":
                case "medium":
                    cost += 50;
                    break;
                case "3":
                case "large":
                    cost += 75;
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please select 1, 2, or 3.");
                    break;
            }
            if (cost != 0)
            {
                Console.WriteLine("Please insert {0} cents.", cost);

            }
            Console.WriteLine("Thank you for your business.");
            }
    }
}
