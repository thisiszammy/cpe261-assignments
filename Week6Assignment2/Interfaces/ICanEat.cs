using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6Assignment2.Interfaces
{
    public interface ICanEat
    {
        public int? Hunger { get; set; }
        public void Eat();
    }
}
