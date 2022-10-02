using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Assignment1.entities
{
    public class Cube : Shape
    {
        double side;
        public double Side
        {
            get { return side; }
            set { side = value; }
        }

        public Cube(double side, ShapeTypeEnum shapeType)
            : base(shapeType)
        {
            this.side = side;
        }
        public override double Area => throw new NotImplementedException();

        public override double Volume
        {
            get
            {
                return Math.Pow(side, 3);
            }
        }

        public override double Perimeter => throw new NotImplementedException();

        public override double SurfaceArea => throw new NotImplementedException();

        public override string ToString()
        {
            return $"ShapeType:{this.ShapeType.ToString()}, Is3Dimensional:{Is3Dimensional.ToString()}, SideLength:{side.ToString("N2")}, Volume:{Volume.ToString("N2")}";
        }
    }
}
