using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeFactory
{
    public interface IShape
    {
        //method declaration for calculatearea
        double CalculateArea();
        //method declaration for calculateperimeter
        double CalculatePerimeter();
    }
}
