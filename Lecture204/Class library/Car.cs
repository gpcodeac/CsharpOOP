using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture204.Class_library
{
    internal class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public bool HasTrunk { get; set; }
        public Car() { }
        public Car(double weight, double maxSpeed, int maxPassengers, bool licenseRequired, int numberOfDoors, bool hasTrunk) : base(weight,maxSpeed,maxPassengers,licenseRequired)
        {
            NumberOfDoors = numberOfDoors;
            HasTrunk = hasTrunk;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Max speed: {MaxSpeed} km/h");
            Console.WriteLine($"Max passengers: {MaxPassengers}");
            Console.WriteLine($"License required: {LicenseRequired}");
            Console.WriteLine($"Number of doors: {NumberOfDoors}");
            Console.WriteLine($"Has trunk: {HasTrunk}");
        }
    }
}
