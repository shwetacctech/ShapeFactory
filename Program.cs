using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating a Circle
            IShape circle = ShapeFactory.CreateShape(ShapeFactory.ShapeType.Circle, 5);
            Console.WriteLine($"Circle - Area: {circle.CalculateArea()}, Perimeter: {circle.CalculatePerimeter()}");

            // Creating a rectangle
            IShape rectangle = ShapeFactory.CreateShape(ShapeFactory.ShapeType.Rectangle, 4, 6);
            Console.WriteLine($"Rectangle - Area: {rectangle.CalculateArea()}, Perimeter: {rectangle.CalculatePerimeter()}");

            // Creating a square
            IShape square = ShapeFactory.CreateShape(ShapeFactory.ShapeType.Square, 4);
            Console.WriteLine($"Square - Area: {square.CalculateArea()}, Perimeter: {square.CalculatePerimeter()}");

            Console.ReadKey();
        }
    }
    
}
