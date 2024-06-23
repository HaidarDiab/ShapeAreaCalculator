using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeAreaCalculator;

namespace ShapeAreaCalculator.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Circle_GetArea_ReturnsCorrectResult()
        {
            var circle = new Circle(5);
            var expected = Math.PI * 25;
            var actual = circle.GetArea();
            Assert.AreEqual(expected, actual, 0.00001);
        }
    }
}
