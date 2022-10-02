using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Assignment1.entities
{
    public abstract class Shape
    {
        ShapeTypeEnum shapeType;
        public ShapeTypeEnum ShapeType { get => shapeType; }

        bool is3Dimensional;
        public bool Is3Dimensional { get => is3Dimensional; }


        public Shape(ShapeTypeEnum shapeType)
        {
            this.shapeType = shapeType;
            switch (shapeType)
            {
                case ShapeTypeEnum.CUBE:
                    is3Dimensional = true;
                    break;
                default:
                    is3Dimensional = false;
                    break;
            }
        }

        public abstract double Area { get; }
        public abstract double Volume { get; }
        public abstract double Perimeter { get; }
        public abstract double SurfaceArea { get; } 

    }
}
