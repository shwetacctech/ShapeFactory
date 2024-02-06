using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeFactory
{
    public class Square: IShape
    {
        //parameter side
        public double Side {  get; set; }
        //Constructor
        public Square(double side)
        {
            Side = side;
        }
        //implementing calculate area method from IShape interface
        public double CalculateArea()
        {
            return Side*Side;
        }
        //implementing calculate perimeter from IShape interface
        public double CalculatePerimeter()
        {
            return 4*Side;
        }
    }
}
