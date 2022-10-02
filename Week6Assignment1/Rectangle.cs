using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6Assignment1
{
    internal class Rectangle : Shape
    {
        internal override double CalculateSurface()
        {
            return Height * Width;
        }

        public override string ToString()
        {
            return $"Shape: Rectangle, Height: {Height.ToString("N2")}, Width:{Width.ToString("N2")}";
        }
    }
}
