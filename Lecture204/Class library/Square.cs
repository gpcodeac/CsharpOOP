using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture204.Class_library
{
    internal class Square : GeometricShape
    {
        private double _side;

        public Square(double side)
        {
            if (side <= 0)
            {
                throw new ArgumentException("Side must be positive.");
            }
            _side = side;
        }

        public override double Area()
        {
            return _side * _side;
        }

        public override double Perimeter()
        {
            return 4 * _side;
        }
    }
}
