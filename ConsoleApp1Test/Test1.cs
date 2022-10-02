using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Test
{
    public class Test1
    {
        static Test1()
        {
            Console.WriteLine("Static A()");
        }

        public Test1()
        {
            Console.WriteLine("A()");
        }
    }
}
