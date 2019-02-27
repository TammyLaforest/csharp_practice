using System;

namespace Mod3_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {   

            // This example code doesn't work for floats.
            int first = 1;
            int second = 0;
            Console.WriteLine("Enter your first number: ");
            first = System.Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number: ");
            second = System.Int32.Parse(Console.ReadLine());

            int result = Divide(first, second);
            Console.WriteLine($"The result of dividing {first} by {second} is {result}");
        }

        static int Divide(int first, int second)
        {

            int result = 0;
            try
            {
                result = first / second;
            }

            // Example code has this as DivideByZeroException Ex but it doesn't work.  This does.
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero, please provide a non-zero value for your second value");

            }
            return result;
        }
    }
}
