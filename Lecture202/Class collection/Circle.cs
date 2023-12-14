using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture202.Class_collection
{
    internal class Circle
    {

        public Circle() { }

        public double Area()
        {
            return Radius * Radius * Math.PI;
        }

        public double Circumference()
        {
            return 2 * Radius * Math.PI;
        }
        public double Radius { get; set; }
    }
}
