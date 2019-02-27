using System;

namespace Mod2_Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            // While Loop Practice
            int n = 1;
            while (n < 6)
            {
                Console.WriteLine($"Current value of n is {n}");
                n++;
            }

            // Do While Loop
            int x = 0;
            do
            {
                Console.WriteLine(x);
                x++;
            } while (x < 5);
        }
    }
}
