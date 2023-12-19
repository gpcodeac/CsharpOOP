using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture203.Class_collection
{
    internal class Car : Vehicle
    {
        public double Mass { get; set; }
        public double CO2perKm { get; set; }
        public double TaxRevenue { get; set; }
        public double ParkingSpaceSqMeters { get; set; }   
        

        public Car() { }
        public Car(double mass, double co2perKm, double taxRevenue, double parkingSpaceSqMeters, double speed)
        {
            Mass = mass;
            CO2perKm = co2perKm;
            TaxRevenue = taxRevenue;
            ParkingSpaceSqMeters = parkingSpaceSqMeters;
            Speed = speed;
        }

    }
}
