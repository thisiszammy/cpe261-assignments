using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6Assignment2.Interfaces;

namespace Week6Assignment2
{
    public class Cat : Animal, ICanEat, ICanDrink
    {
        string name;
        public string Name { get => name; set => name = value; }
        public int? Hunger { get; set; }
        public int? Thirst { get; set; }

        public Cat(string name)
        {
            this.name = name;
        }

        public void Eat()
        {
            Hunger = (Hunger.HasValue) ? Hunger++ : 0;
            Velocity = 0;
            Console.Write("{0} proceeds to eat a wild mouse...", name);
        }

        public void Drink()
        {
            Velocity = 0;
            Thirst = (Thirst.HasValue) ? Thirst++ : 0;
            Console.WriteLine("{0} proceeds to drink a bowl of milk...", name);
        }

        public override void Back()
        {
            Console.WriteLine("{0} lazily struts to his pillow...", name);
        }

        public override double GetVelocity()
        {
            return Velocity;
        }

        public override void Run()
        {
            Velocity = 15;
            Console.WriteLine("{0} proceeds to valiantly prance towards his prey at {1:F2} m/s...", name, Velocity);
        }
    }
}
