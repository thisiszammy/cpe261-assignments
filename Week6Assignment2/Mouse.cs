using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6Assignment2.Interfaces;

namespace Week6Assignment2
{
    public class Mouse : Animal, ICanEat, ICanDrink
    {
        public int? Hunger { get; set; }
        public int? Thirst { get; set; }

        public override void Back()
        {
            Console.WriteLine("Mouse Runs back to his hole...");
        }

        public void Drink()
        {
            Velocity = 0;
            Thirst = (Thirst.HasValue) ? Thirst++ : 0;
            Console.WriteLine("Mouse proceeds to drink from a dirty puddle...");
        }

        public void Eat()
        {
            Velocity = 0;
            Hunger = (Hunger.HasValue) ? Hunger++ : 0;
            Console.WriteLine("Mouse proceeds to eat garbage...");
        }

        public override double GetVelocity()
        {
            return Velocity;
        }

    }
}
