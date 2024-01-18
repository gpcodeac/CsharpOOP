using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture215.Classes
{
    internal class Quadrilateral : IPolygon
    {
        private double _side1;
        private double _side2;
        private double _side3;
        private double _side4;
        private double _diagonal;
        public Quadrilateral() { }

        public Quadrilateral(double side1, double side2, double side3, double side4, double diagonal)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0 || side4 <= 0 || diagonal <= 0)
            {
                throw new ArgumentOutOfRangeException("All sides and diagonal must be greater than 0");
            }
            if (side1 >= side2 + side3 + side4 || side2 >= side1 + side3 + side4 || side3 >= side1 + side2 + side4 || side4 >= side1 + side2 + side3)
            {
                throw new ArgumentOutOfRangeException("The sum of any three sides must be greater than the fourth side");
            }
            if ((diagonal >= side1 + side2 && diagonal >= side2 + side3) || (diagonal >= side3 + side4 && diagonal >= side2 + side3))
            {
                throw new ArgumentOutOfRangeException("The diagonal does not fit.");
            }
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
            _side4 = side4;
            _diagonal = diagonal;
        }

        public int NumberOfSides { get; set; } = 4;

        public double Side1
        {
            get { return _side1; }
            set
            {
                if (value > 0 && value < Side2 + Side3 + Side4)
                {
                    _side1 = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Side1", "Side1 must be greater than 0 and less than the sum of Side2, Side3, and Side4");
                }
            }
        }

        public double Side2
        {
            get { return _side2; }
            set
            {
                if (value > 0 && value < Side1 + Side3 + Side4)
                {
                    _side2 = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Side2", "Side2 must be greater than 0 and less than the sum of Side1, Side3, and Side4");
                }
            }
        }

        public double Side3
        {
            get { return _side3; }
            set
            {
                if (value > 0 && value < Side1 + Side2 + Side4)
                {
                    _side3 = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Side3", "Side3 must be greater than 0 and less than the sum of Side1, Side2, and Side4");
                }
            }
        }

        public double Side4
        {
            get { return _side4; }
            set
            {
                if (value > 0 && value < Side1 + Side2 + Side3)
                {
                    _side4 = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Side4", "Side4 must be greater than 0 and less than the sum of Side1, Side2, and Side3");
                }
            }
        }

        public double Diagonal
        {
            get { return _diagonal; }
            set
            {
                if (value > 0 && (value < Side1 + Side2 || value < Side2 + Side3) && (value < Side3 + Side4 || value < Side4 + Side1))
                {
                    _diagonal = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The diagonal does not fit");
                }
            }
        }

        public double GetArea()
        {
            double s1 = (Side1 + Side2 + Diagonal) / 2;
            double halfArea1 = Math.Sqrt(s1 * (s1 - Side1) * (s1 - Side2) * (s1 - Diagonal));
            double s2 = (Side3 + Side4 + Diagonal) / 2;
            double halfArea2 = Math.Sqrt(s2 * (s2 - Side3) * (s2 - Side4) * (s2 - Diagonal));
            return halfArea1 + halfArea2;
        }

        public double GetPerimeter()
        {
            return Side1 + Side2 + Side3 + Side4;
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
