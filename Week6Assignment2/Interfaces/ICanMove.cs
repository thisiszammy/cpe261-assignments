using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6Assignment2.Interfaces
{
    public interface ICanMove
    {
        public double Velocity { get; set; }
        public void Run();
        public void Back();
        public double GetVelocity();
    }
}
