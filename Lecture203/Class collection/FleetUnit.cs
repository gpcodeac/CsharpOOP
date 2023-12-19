using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture203.Class_collection
{
    internal class FleetUnit
    {
        public FleetUnit() { }
        public FleetUnit(string model, string vin, int capacity, double odometer)
        {
            Model = model;
            Vin = vin;
            Capacity = capacity;
            Odometer = odometer;
        }
        public string Model { get; set; }
        public string Vin { get; set; }
        public int Capacity { get; set; }
        public double Odometer { get; set; }
        public (double, double) Location { get; set; }
        public bool ActiveReservation { get; set; }

        public void Reserve()
        {
            ActiveReservation = true;
        }
        public void EndReservation()
        {
            ActiveReservation = false;
        }

        public int GetCapacity()
        {
            return Capacity;
        }


    }
}
