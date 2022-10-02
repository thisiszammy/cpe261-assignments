using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6Assignment1
{
    internal class Circle : Shape
    {

        public Circle(double radius)
        {
            this.Width = radius;
            this.Height = radius;
        }

        internal override double CalculateSurface()
        {
            return Math.PI * (Width * Height);
        }

        public override string ToString()
        {
            return $"Shape: Circle, Radius:{Width.ToString("N2")}";
        }
    }
}
