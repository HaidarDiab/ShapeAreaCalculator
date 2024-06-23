using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeAreaCalculator;

namespace ShapeAreaCalculator.Tests
{
    [TestClass]
    public class ShapeFactoryTests
    {
        [TestMethod]
        public void ShapeFactory_CreateCircle_ReturnsCircleInstance()
        {
            var shape = ShapeFactory.CreateShape("circle", 5);
            Assert.IsInstanceOfType(shape, typeof(Circle));
        }

        [TestMethod]
        public void ShapeFactory_CreateTriangle_ReturnsTriangleInstance()
        {
            var shape = ShapeFactory.CreateShape("triangle", 3, 4, 5);
            Assert.IsInstanceOfType(shape, typeof(Triangle));
        }

        [TestMethod]
        public void ShapeFactory_CreateUnknownShape_ThrowsNotImplementedException()
        {
            Assert.ThrowsException<NotImplementedException>(() => ShapeFactory.CreateShape("hexagon", 2));
        }
    }
}
