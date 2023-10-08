using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AreaOfFigure.Tests
{
    [TestClass]
    public class TriangleTests
    {
        double e = 0.0001;

        [TestMethod]
        public void TriangleArea_3_4_5()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;
            Triangle triangle = new Triangle(a, b, c);
            double actual = triangle.GetArea();
            Assert.IsTrue(Math.Abs(expected - actual) < e);
        }

        [TestMethod]
        public void TriangleArea_5_8_6()
        {
            double a = 5;
            double b = 8;
            double c = 6;
            double expected = 14.98124;
            Triangle triangle = new Triangle(a, b, c);
            double actual = triangle.GetArea();
            Assert.IsTrue(Math.Abs(expected - actual) < e);
        }

        [TestMethod]
        public void TriangleIsRectangular_3_5_4()
        {
            double a = 3;
            double b = 5;
            double c = 4;
            Triangle triangle = new Triangle(a, b, c);
            Assert.IsTrue(triangle.IsRectangularTriangle());
        }

        [TestMethod]
        public void TriangleIsRectangular_3_5_6()
        {
            double a = 3;
            double b = 5;
            double c = 6;
            Triangle triangle = new Triangle(a, b, c);
            Assert.IsTrue(!triangle.IsRectangularTriangle());
        }
    }

    [TestClass]
    public class CircleTests
    {
        double e = 0.0001;

        [TestMethod]
        public void CircleArea_3()
        {
            double r = 3;
            double expected = 28.27433;
            Circle circle = new Circle(r);
            double actual = circle.GetArea();
            Assert.IsTrue(Math.Abs(expected - actual) < e);
        }

        [TestMethod]
        public void CircleArea_1()
        {
            double r = 1;
            double expected = Math.PI;
            Circle circle = new Circle(r);
            double actual = circle.GetArea();
            Assert.IsTrue(Math.Abs(expected - actual) < e);
        }
    }
}
