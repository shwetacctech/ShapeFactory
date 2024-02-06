using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeFactory
{
    internal class ShapeFactory
    {
        //enumerator of shapes type
        public enum ShapeType
        {
            Circle,
            Rectangle,
            Square
        }
        //Creats shape according to inputs
        public static IShape CreateShape(ShapeType type, params double[] parameters)
        {
            switch (type)
            {
                case ShapeType.Circle:
                    if (parameters.Length == 1)
                        return new Circle(parameters[0]);
                    break;
                case ShapeType.Rectangle:
                    if (parameters.Length == 2)
                        return new Rectangle(parameters[0], parameters[1]);
                    break;
                case ShapeType.Square:
                    if (parameters.Length == 1)
                        return new Square(parameters[0]);
                    break;
            }

            throw new ArgumentException("Invalid number of parameters for the specified shape type.");
        }
    }
}
