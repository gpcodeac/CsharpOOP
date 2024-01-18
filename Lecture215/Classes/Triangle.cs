using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture215.Classes
{
    internal class Triangle : IPolygon
    {
        private double _side1;
        private double _side2;
        private double _side3;
        public Triangle() { }

        public Triangle(double side1, double side2, double side3)
        {
            if(side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new ArgumentOutOfRangeException("side1, side2, side3", "All sides must be greater than 0");
            }
            if(side1 >= side2 + side3 || side2 >= side1 + side3 || side3 >= side1 + side2)
            {
                throw new ArgumentOutOfRangeException("side1, side2, side3", "The sum of any two sides must be greater than the third side");
            }
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        public int NumberOfSides { get; set; } = 3;

        public double Side1
        {
            get { return _side1; }
            set
            {
                if (value > 0 && value < Side2 + Side3)
                {
                    _side1 = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Side1", "Side1 must be greater than 0 and less than the sum of Side2 and Side3");
                }
            }
        }

        public double Side2
        {
            get { return _side2; }
            set
            {
                if (value > 0 && value < Side1 + Side3)
                {
                    _side2 = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Side2", "Side2 must be greater than 0 and less than the sum of Side1 and Side3");
                }
            }
        }

        public double Side3
        {
            get { return _side3; }
            set
            {
                if (value > 0 && value < Side1 + Side2)
                {
                    _side3 = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Side3", "Side3 must be greater than 0 and less than the sum of Side1 and Side2");
                }
            }
        }

        public double GetArea()
        {
            double s = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
        }
        public double GetPerimeter()
        {
            return Side1 + Side2 + Side3;
        }

        public int CompareTo(IPolygon? other)
        {
            if (other == null)
            {
                return 1;
            }
            else
            {
                return GetArea().CompareTo(other.GetArea());
            }
        }
    }
}
