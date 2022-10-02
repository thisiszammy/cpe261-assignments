using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public static class Assignment3C
    {
        public static void Run()
        {
            double radius;
            Console.WriteLine("\n======================\nRunning Assignment 3_C\n======================");

            start:
                Console.Write("Enter Radius of Circle: ");
                var _radius = Console.ReadLine();
                
                if(!double.TryParse(_radius, out radius))
                {
                    Console.WriteLine("Invalid Value Entered! Please Try Again!");
                    goto start;
                }

                Console.WriteLine("Area of Circle: {0:F2}", (Math.PI * Math.Pow(radius,2)));
        }
    }
}
