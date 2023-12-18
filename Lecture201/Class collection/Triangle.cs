using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lecture201
{
    internal class Triangle
    {
        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        private double GetPerimeter()
        {
            return Side1 + Side2 + Side3;
        }

        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }
        public double Perimeter { get => GetPerimeter(); }
        public double Area
        {
            get
            {
                double halfP = 0;
                halfP = Perimeter / 2;
                return Math.Sqrt(halfP * (halfP - Side1) * (halfP - Side2) * (halfP - Side3));
            }
        }
    }
}
