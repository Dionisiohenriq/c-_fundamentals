using GeometricFigures.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures.Entities
{
    public abstract class Shape
    {
        public EColor Color { get; set; }
        public Shape() { }

        public Shape(EColor color) 
        {
            Color = color;
        }

        public abstract double Area();
    }
}
