using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeFactory
{
    public class Circle : IShape
    {
        //parameter radius
        public double Radius { get; }
        //Constructor
        public Circle(double radius)
        {
            Radius = radius;
        }
        //implementing calculate area method from IShape interface
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        //implementing calculate perimeter from IShape interface
        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
        
}
