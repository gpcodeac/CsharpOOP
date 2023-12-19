using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture203.Class_collection
{
    internal class Bike : Vehicle
    {
        public double ParkingSpaceSqMeters { get; set; }
        public double TaxRevenue { get; set; } 
        public double HealthCareSavingsPerKm{ get; set; }
        public Bike() { }
        public Bike(double parkingSpaceSqMeters, double taxRevenue, double healthCareSavingsPerKm, double speed)
        {
            ParkingSpaceSqMeters = parkingSpaceSqMeters;
            TaxRevenue = taxRevenue;
            HealthCareSavingsPerKm = healthCareSavingsPerKm;
            Speed = speed;
        }
        
    }
}
