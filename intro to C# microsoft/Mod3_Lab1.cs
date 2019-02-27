using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_Lab1
{
    class Program



    {


        //static void Main(string[] args)
        //{
        //    // First method doesn't return
        //    Sum(20, 40);
        //}

        // static void Sum(int first, int second)
       
        //{
        //    // First method doesn't return
        //    int sum = first + second;
        //    Console.WriteLine($"The sum of {first} and {second} is: {sum}");
        //}


        //static void Main(string[] args)
        //{

        //    // Second method has return
        //    int result = Sum(20, 40);
        //    Console.WriteLine($"The sum of 20 and 40 is {result}");
        //}

        //static int Sum(int first, int second)
        //{
        //    // Second method has return
        //    int sum = first + second;
        //    return sum;
        //}


        static void Main(string[] args)
        {

            // Third method overrides
            int result = Sum(20, 40);
            Console.WriteLine($"Calling Sum() with two arguments, result is: {result}");

            int result3 = Sum(10, 50, 80);
            Console.WriteLine($"Calling Sum() with three arguments, result is: {result3}");

            double dblResult = Sum(20.5, 30.6);
            Console.WriteLine($"Calling Sum() that takes doubles, results is: {dblResult}");
        
        }


        static int Sum(int first, int second)
        {
            // Third method overrides
            int sum = first + second;
            return sum;
        }

        static int Sum(int first, int second, int third)
        {
            // Third method overrides
            int sum = first + second + third;
            return sum;
        }

        static double Sum(double first, double second)
        {
            double result = first + second;
            return result;
        }


    }
}
