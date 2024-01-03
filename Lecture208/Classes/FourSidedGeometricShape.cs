using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture208.Classes
{
    internal class FourSidedGeometricShape
    {
        private string _name;
        private double _base;
        private double _height;

        public FourSidedGeometricShape()
        {

        }
        public FourSidedGeometricShape(string name, double @base, double height)
        {
            Name = name;
            Base = @base;
            Height = height;
        }

        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }
        public double Base
        {
            get { return _base; }
            private set
            {
                if (value < 0)
                {
                    Console.WriteLine("Cannot set a negative value for Base.");
                }
                else
                {
                    _base = value;
                }
            }

        }
        public double Height
        {
            get { return _height; }
            private set 
            {
                if (value < 0)
                {
                    Console.WriteLine("Cannot set a negative value for Height.");
                }
                else
                {
                    _height = value;
                }
            }
        }

        public double CalculateArea()
        {
            return Base * Height;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Base: {Base}, Height: {Height}, Area: {CalculateArea()}";
        }
    }
}
