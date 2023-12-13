using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Lecture201
{
    internal class Square
    {
        public Square() { }

        public Square(double side1, double side2)
        {
            Side1 = side1;
            Side2 = side2;
        }

        private double side1;
        private double side2;

        public double Side1
        {
            get 
            {
                return side1;
            }
            set
            {
                side1 = value;
                Perimeter = (2 * value) + (2 * side2);
                Area = value * side2;
            }
        }
        public double Side2 
        {
            get
            {
                return side2;
            }
            set
            {
                side2 = value;
                Perimeter = (2 * value) + (2 * side1);
                Area = value * side1;
            }
        }

        public double Perimeter { get; private set; }
        public double Area { get; private set; }
    }
}
