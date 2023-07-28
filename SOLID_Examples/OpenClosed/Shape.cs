using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Examples.OpenClosed
{

    public abstract class Shape
    {
        public abstract double Area();
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class AreaCalculator
    {
        public double CalculateTotalArea(Shape[] shapes)
        {
            double totalArea = 0;
            foreach (var shape in shapes)
            {
                totalArea += shape.Area();
            }
            return totalArea;
        }
    }

}

