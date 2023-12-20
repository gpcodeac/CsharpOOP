using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture204.Class_library
{
    internal class Scooter : Vehicle
    {
        public bool HasBasket { get; set; }
        public int Range { get; set; }
        public Scooter() { }
        public Scooter(double weight, double maxSpeed, int maxPassengers, bool licenseRequired, int range, bool hasBasket) : base(weight,maxSpeed,maxPassengers,licenseRequired)
        {
            Range = range;
            HasBasket = hasBasket;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Max speed: {MaxSpeed} km/h");
            Console.WriteLine($"Max passengers: {MaxPassengers}");
            Console.WriteLine($"License required: {LicenseRequired}");
            Console.WriteLine($"Range: {Range} km");
            Console.WriteLine($"Has basket: {HasBasket}");
        }
    }
}
