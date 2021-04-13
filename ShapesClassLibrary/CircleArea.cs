using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesClassLibrary
{
    public class CircleArea
    {
        public double Radius { get; set; }

        public CircleArea(double rad)
        {
            this.Radius = rad;
        }

        public double CircleAreaCalculate()
        {
            return Math.Round(Convert.ToDouble(Math.PI * Radius * Radius), 2);
        }
    }
}
