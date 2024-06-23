using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeAreaCalculator;

namespace ShapeAreaCalculator.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Triangle_GetArea_ReturnsCorrectResult()
        {
            var triangle = new Triangle(3, 4, 5);
            var expected = 6;
            var actual = triangle.GetArea();
            Assert.AreEqual(expected, actual, 0.00001);
        }

        [TestMethod]
        public void Triangle_IsRightAngled_ReturnsTrueForRightAngledTriangle()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRightAngled());
        }

        [TestMethod]
        public void Triangle_IsRightAngled_ReturnsFalseForNonRightAngledTriangle()
        {
            var triangle = new Triangle(3, 4, 6);
            Assert.IsFalse(triangle.IsRightAngled());
        }
    }
}
