using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public static class Assignment3A
    {
        public static void Run()
        {
            Single ikl = 3.4F;
            int[] data = new int[] { 1, 3, 4, 5, 6 };
            Console.WriteLine("\n======================\nRunning Assignment 3_A\n======================" + ikl);
            start:
                Console.Write("Please Enter Your Name : ");

                string? name = Console.ReadLine() ?? string.Empty;

                if (string.IsNullOrEmpty(name.Trim()))
                {
                    Console.WriteLine("No Name Entered! Please Try Again!");
                    goto start; 
                }

                Console.WriteLine("Entered Name : {0}", name);
           
        }

        public static void BoilerPlate()
        {
            Console.Write("");
            Console.WriteLine("");
            Console.ReadLine();

        }

        internal class Test1
        {
            public void HellloWorld()
            {

            }
        }

    }


}
