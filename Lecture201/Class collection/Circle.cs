using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lecture201
{
    internal class Circle
    {
        public Circle() { }

        public Circle(double radius)
        {
            Radius = radius;
            Circumference = radius * 2 * Math.PI;
            //Area = radius * radius * Math.PI;
            //SetArea(Radius);
        }

        //public void SetArea(double radius)
        //{

        //}

        private double circumference;

        public double Radius { get; set; }
        public double Circumference 
        {   get 
            {
                return circumference;
            }
            private set
            {
                circumference = value;
            }
        }
        public double Area 
        {
            get => Radius * Radius * Math.PI;
            //private set; //--i dont need a setter because getter will always compute result, when I dont have a setter like that the field is read-only
        }
    }
}
