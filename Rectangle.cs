using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeFactory
{
    public class Rectangle : IShape
    {
        //length parameter
        public double Length { get; set; }
        //width parameter
        public double Width { get; set; }

        //constructor
        public Rectangle(double length, double width) 
        {
            Length = length;        
            Width = width;
        }
        //implementing calculate area method from IShape interface
        public double CalculateArea()
        {
            return Length*Width;
        }
        //implementing calculate perimeter from IShape interface
        public double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }
    }
}
