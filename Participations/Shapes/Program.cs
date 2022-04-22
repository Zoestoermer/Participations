//Participation 13.1 - Shapes Classes
using System;

namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            Rectangle rect2 = new Rectangle();

            Circle circle = new Circle();
            Circle circle2 = new Circle();


            rect.Length = 5;
            rect.Width = 10;
            rect.CalculateArea();
            rect.CalculatePerimeter();

            rect2.Length = 7;
            rect2.Width = 10;
            rect2.CalculateArea();
            rect2.CalculatePerimeter();

            circle.Radius = 4;
            double circleArea = circle.CalculateArea();
            double circlePerm = circle.CalculatePerimeter();

            circle2.Radius = 8;
            double circleArea2 = circle2.CalculateArea();
            double circlePerm2 = circle2.CalculatePerimeter();

            Console.WriteLine($"Circle 1 area is: {circleArea}");
            Console.WriteLine($"Rectangle 1 area is: {rect.GetArea()}");

            foreach (var prop in circle.GetType().GetProperties())
            {
                Console.WriteLine(prop.Name);
            }
        }
    }
}
