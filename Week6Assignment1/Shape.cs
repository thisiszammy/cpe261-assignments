using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6Assignment1
{
    internal abstract class Shape
    {
        internal double Width { get; set; }
        internal double Height { get; set; }
        internal abstract double CalculateSurface();
    }
}
