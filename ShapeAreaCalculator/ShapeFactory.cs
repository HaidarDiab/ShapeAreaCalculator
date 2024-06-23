using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    public static class ShapeFactory
    {
        public static Shape CreateShape(string shapeType, params double[] parameters)
        {
            switch (shapeType.ToLower())
            {
                case "circle":
                    if (parameters.Length != 1) throw new ArgumentException("Circle requires exactly 1 parameter: radius.");
                    return new Circle(parameters[0]);
                case "triangle":
                    if (parameters.Length != 3) throw new ArgumentException("Triangle requires exactly 3 parameters: sides a, b, and c.");
                    return new Triangle(parameters[0], parameters[1], parameters[2]);
                default:
                    throw new NotImplementedException($"Shape type '{shapeType}' is not implemented.");
            }
        }
    }
}
