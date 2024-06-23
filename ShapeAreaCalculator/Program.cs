using System;
using ShapeAreaCalculator;

namespace ShapeAreaCalculator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculate the area of a circle
            var circle = new Circle(5);
            Console.WriteLine($"The area of the circle with radius {circle.Radius} is {circle.GetArea()}");

            // Calculate the area of a triangle
            var triangle = new Triangle(3, 4, 5);
            Console.WriteLine($"The area of the triangle with sides {triangle.SideA}, {triangle.SideB}, and {triangle.SideC} is {triangle.GetArea()}");

            // Check if the triangle is right-angled
            if (triangle.IsRightAngled())
            {
                Console.WriteLine("The triangle is right-angled.");
            }
            else
            {
                Console.WriteLine("The triangle is not right-angled.");
            }

            // Use ShapeFactory to create shapes
            var shape1 = ShapeFactory.CreateShape("circle", 7);
            var shape2 = ShapeFactory.CreateShape("triangle", 6, 8, 10);

            Console.WriteLine($"The area of the shape1 (circle) is {shape1.GetArea()}");
            Console.WriteLine($"The area of the shape2 (triangle) is {shape2.GetArea()}");

            // Additional runtime shape creation
            string shapeType;
            double[] parameters;

            Console.WriteLine("Enter the shape type (circle/triangle): ");
            shapeType = Console.ReadLine().ToLower();

            if (shapeType == "circle")
            {
                Console.WriteLine("Enter the radius: ");
                parameters = new double[] { double.Parse(Console.ReadLine()) };
            }
            else if (shapeType == "triangle")
            {
                Console.WriteLine("Enter the three sides: ");
                parameters = new double[]
                {
                    double.Parse(Console.ReadLine()),
                    double.Parse(Console.ReadLine()),
                    double.Parse(Console.ReadLine())
                };
            }
            else
            {
                Console.WriteLine("Invalid shape type.");
                return;
            }

            var shape = ShapeFactory.CreateShape(shapeType, parameters);
            Console.WriteLine($"The area of the {shapeType} is {shape.GetArea()}");
        }
    }
}
