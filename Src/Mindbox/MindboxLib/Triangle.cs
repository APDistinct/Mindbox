using MindboxLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxLib
{
    public class Triangle : IFigure
    {
        public double Side1 { get; }
        public double Side2 { get; }
        public double Side3 { get; }
        private const double _eps = 1e-10;
        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                throw new ArgumentException("All sides value must be greater than zero.");

            if (side1 + side2 <= side3 || side2 + side3 <= side1 || side3 + side1 <= side2)
                throw new ArgumentException("The sum of any two sides must be greater than the remaining side.");

            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public double GetArea()
        {
            double p = (Side1 + Side2 + Side3) * 0.5;
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }

        public bool IsRightTriangle()
        {
            double[] sides = { Side1, Side2, Side3 };
            Array.Sort(sides);
            return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < _eps;
        }
    }
}
