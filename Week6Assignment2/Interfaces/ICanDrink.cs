using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6Assignment2.Interfaces
{
    public interface ICanDrink
    {
        public int? Thirst { get; set; }
        public void Drink();
    }
}
