using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture204.Class_library
{
    internal class Bus : Vehicle
    {
        public int NumberOfSeats { get; set; }
        public int NumberOfStandingPlaces { get; set; }
        public bool HasToilet { get; set; }
        public Bus() { }
        public Bus(double weight, double maxSpeed, int maxPassengers, bool licenseRequired, int numberOfSeats, int numberOfStandingPlaces, bool hasToilet) : base(weight,maxSpeed,maxPassengers,licenseRequired)
        {
            NumberOfSeats = numberOfSeats;
            NumberOfStandingPlaces = numberOfStandingPlaces;
            HasToilet = hasToilet;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Max speed: {MaxSpeed} km/h");
            Console.WriteLine($"Max passengers: {MaxPassengers}");
            Console.WriteLine($"License required: {LicenseRequired}");
            Console.WriteLine($"Number of seats: {NumberOfSeats}");
            Console.WriteLine($"Number of standing places: {NumberOfStandingPlaces}");
            Console.WriteLine($"Has toilet: {HasToilet}");
        }
    }
}
