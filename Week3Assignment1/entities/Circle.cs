using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Assignment1.entities
{
    public class Circle : Shape
    {
        double radius;
        public double Radius 
        { 
            get { return radius; }
            set { radius = value; } 
        }

        public Circle(double radius, ShapeTypeEnum shapeType)
            : base(shapeType)
        {
            this.radius = radius;
        }

        public override double Area
        {
            get
            {
                return Math.PI * Math.Pow(radius, 2);
            }
        }

        public override double Volume => throw new NotImplementedException();

        public override double Perimeter => throw new NotImplementedException();

        public override double SurfaceArea => throw new NotImplementedException();
        public override string ToString()
        {
            return $"ShapeType:{this.ShapeType.ToString()}, Is3Dimensional:{Is3Dimensional.ToString()}, Radius:{radius.ToString("N2")}, Area:{Area.ToString("N2")}";
        }
    }
}

