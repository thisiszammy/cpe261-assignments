using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public static class Assignment3B
    {
        public static void Run()
        {
            double num1, num2, num3;

            Console.WriteLine("\n======================\nRunning Assignment 3_B\n======================");

            start:

                Console.WriteLine("[Enter 3 Numbers]");

                Console.Write("1st Number: ");
                var _num1 = Console.ReadLine();

                Console.Write("2nd Number: ");
                var _num2 = Console.ReadLine();

                Console.Write("3rd Number: ");
                var _num3 = Console.ReadLine();

                if (!double.TryParse(_num1, out num1) ||
                    !double.TryParse(_num2, out num2) ||
                    !double.TryParse(_num3, out num3))
                {
                    Console.WriteLine("Invalid Input! Please Try Again!");
                    goto start;
                }

                Console.WriteLine("Average of Numbers : {0:F2}", (num1+num2+num3)/3);

        }
    }
}
