using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigure
{
    public abstract class Figure
    {
        public abstract double GetArea();
    }

    public class Circle : Figure
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }

    public class Triangle : Figure
    {
        private double a, b, c;
        private double e = Double.Epsilon;

        public Triangle(double side1, double side2, double side3)
        {
            this.a = side1;
            this.b = side2;
            this.c = side3;
        }

        public bool IsRectangularTriangle()
        {
            if (a > b && a > c)
                return Math.Abs(Math.Pow(b, 2) +
                    Math.Pow(c, 2) - Math.Pow(a, 2)) < e;
            if (b > a && b > c)
                return Math.Abs(Math.Pow(a, 2) +
                    Math.Pow(c, 2) - Math.Pow(b, 2)) < e;
            return Math.Abs(Math.Pow(a, 2) +
                Math.Pow(b, 2) - Math.Pow(c, 2)) < e;
        }

        public override double GetArea()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
