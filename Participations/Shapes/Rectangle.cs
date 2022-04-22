using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    internal class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }
        private double Area { get; set; }
        private double Perimeter { get; set; }


        public Rectangle()
        {
            Length = 0;
            Width = 0;
        }

        public void CalculatePerimeter()
        {
            Perimeter =  2*(Length + Width);
        }

        public void CalculateArea()
        {
            Area = Length * Width;
        }

        public double GetArea()
        {
            return Area;
        }

        public double GetPerimeter()
        {
            return Perimeter;
        }
    }
}
