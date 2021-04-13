using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesClassLibrary;
using System;

namespace AreaCalculateTest
{
    [TestClass]
    public class AreaCalculatorTest
    {
        [TestMethod]
        public void CircleAreaCalculate_Radius_ReturnsCircleArea()
        {
            // Arrange
            double radius = 10;
            double expectedCircleArea = 314.16;

            // Act
            var circle = new CircleArea(radius);
            double actualCircleArea = circle.CircleAreaCalculate();

            // Assert
            Assert.AreEqual(expectedCircleArea, actualCircleArea);

        }

        [TestMethod]
        public void TriangleAreaCalculate_ThreeSides_ReturnsTriangleArea()
        {
            // Arrange
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            double expectedTriangleArea = 6;

            // Act
            var triangle = new TriangleArea(side1, side2, side3);
            double actualTriangleArea = triangle.TriangleAreaCalculate();

            // Assert
            Assert.AreEqual(expectedTriangleArea, actualTriangleArea);
        }

        [TestMethod]
        public void TriangleCheckIfRightYriangle_ThreeSides_ReturnsTrueIfRightTriangle()
        {
            // Arrange
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;

            // Act
            var triangle = new TriangleArea(side1, side2, side3);
            bool actualRightTriangle = triangle.CheckIfRightTriangle();

            // Assert            
            Assert.IsTrue(actualRightTriangle);
        }
    }
}
