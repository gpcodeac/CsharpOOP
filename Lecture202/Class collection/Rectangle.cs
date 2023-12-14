using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture202 
{
    internal class Rectangle
    {

        public double Perimeter()
        {
            return (Height + Width) * 2;
        }

        public double Area()
        {
            return Height * Width;
        }

        public double Height { get; set; }
        public double Width { get; set; }

    }
}
