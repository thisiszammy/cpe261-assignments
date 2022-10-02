using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6Assignment2.Interfaces;

namespace Week6Assignment2
{
    public abstract class Animal : ICanMove
    {
        public double Velocity { get; set; }
        public abstract void Back();
        public abstract double GetVelocity();
        public virtual void Run()
        {
            Velocity = 5;
            Console.WriteLine("Animal proceeds to run away from a predator at {0} m/s...", Velocity);
        }

    }
}
