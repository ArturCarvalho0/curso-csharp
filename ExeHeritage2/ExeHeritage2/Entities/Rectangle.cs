using ExeHeritage2.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeHeritage2.Entities
{
    internal class Rectangle : Shape
    {
        public Rectangle(double width, double height,Color color) : base(color)
        {
            Width = width;
            Height = height;
        }

        public double Width { get; set; }

        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
