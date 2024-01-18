using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture215.Classes
{
    internal interface IPolygon : IComparable<IPolygon>
    {
        public int NumberOfSides { get; set; }
        public double GetPerimeter();
        public double GetArea();

    }
}
