using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture214.Classes_and_Interfaces
{
    internal class CarComparer : IComparer<Car>
    {
        public int Compare(Car? x, Car? y)
        {
            if (x == null && y != null)
            {
                return 1;
            }
            if (x != null && y == null)
            {
                return -1;
            }
            if (x == null && y == null)
            {
                return 0;
            }
            return string.Compare(x.Model, y.Model, StringComparison.Ordinal);
        }
    }
}
