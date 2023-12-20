using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture204.Class_library
{
    internal abstract class Vehicle
    {
        public double Weight { get; set; }
        public double MaxSpeed { get; set; }
        public int MaxPassengers { get; set; }
        public bool LicenseRequired { get; set; }

        public Vehicle() { }
        public Vehicle(double weight, double maxSpeed, int maxPassengers, bool licenseRequired)
        {
            Weight = weight;
            MaxSpeed = maxSpeed;
            MaxPassengers = maxPassengers;
            LicenseRequired = licenseRequired;
        }
    }
}
