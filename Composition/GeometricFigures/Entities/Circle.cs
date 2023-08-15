using GeometricFigures.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures.Entities
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle()
        {
            
        }

        public Circle(EColor color, double radius) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
