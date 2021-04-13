using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesClassLibrary
{
    public class TriangleArea
    {
        // Properties
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        // Constructor
        public TriangleArea(double side1, double side2, double side3)
        {
            this.Side1 = side1;
            this.Side2 = side2;
            this.Side3 = side3;
        }

        // Calculate Triangle Area Method
        public double TriangleAreaCalculate()
        {
            // Using Heron's Formula

            double s = (Side1 + Side2 + Side3) / 2;

            return Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
        }

        // Checking if it's a right triangle
        public bool CheckIfRightTriangle()
        {
            bool blnRightTriangle = false;
            double hypotenuse;
            double shortSide1;
            double shortSide2;

            if (Side1 == Side2 && Side1 == Side3)
            {
                return blnRightTriangle;
            }
            else
            {
                // find the longest side (hypotenuse) and the short sides
                if (Side1 > Side2 && Side1 > Side3)
                {
                    hypotenuse = Side1;
                    shortSide1 = Side2;
                    shortSide2 = Side3;
                }
                else if (Side2 > Side1 && Side2 > Side3)
                {
                    hypotenuse = Side2;
                    shortSide1 = Side1;
                    shortSide2 = Side3;
                }
                else
                {
                    hypotenuse = Side3;
                    shortSide1 = Side1;
                    shortSide2 = Side2;
                }

                // Using Pythagorean Theorem to check if it's a right triangle
                if (hypotenuse == Math.Sqrt(Math.Pow(shortSide1, 2) + Math.Pow(shortSide2, 2)))
                {
                    blnRightTriangle = true;
                }

                return blnRightTriangle;
            }
        }
    }
}
