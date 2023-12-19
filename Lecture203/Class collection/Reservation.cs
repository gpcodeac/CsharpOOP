using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture203.Class_collection
{
    internal class Reservation
    {
        public Reservation() { }
        public Reservation(Customer customer, FleetUnit fleetUnit)
        {
            Customer = customer;
            FleetUnit = fleetUnit;
        }
        public Customer Customer { get; set; }
        public FleetUnit FleetUnit { get; set; }
        private DateTime ReservationStart { get; set; }
        private DateTime ReservationEnd { get; set; }
        private double TripStartOdometer { get; set; }
        private double TripEndOdometer { get; set; }
        private bool ActiveReservation { get; set; }
        public double Price
        {
            get
            {
                return Trip * 0.29;
            }
        }
        public double Trip
        {
            get
            {
                return TripEndOdometer - TripStartOdometer;
            }
        }

        public void Reserve()
        {
            ActiveReservation = true;
            ReservationStart = DateTime.Now;
            TripStartOdometer = FleetUnit.Odometer;
            FleetUnit.Reserve();
        }
        public void EndReservation()
        {
            ActiveReservation = false;
            ReservationEnd = DateTime.Now;
            TripEndOdometer = FleetUnit.Odometer;
            FleetUnit.EndReservation(); 
        }

        public void PrintReservation()
        {
            Console.WriteLine($"Customer: {Customer.Name}");
            Console.WriteLine($"Fleet unit: {FleetUnit.Model}");
            Console.WriteLine($"Reservation start: {ReservationStart}");
            Console.WriteLine($"Reservation end: {ReservationEnd}");
            Console.WriteLine($"Trip start odometer: {TripStartOdometer}");
            Console.WriteLine($"Trip end odometer: {TripEndOdometer}");
            Console.WriteLine($"Trip: {Trip}");
            Console.WriteLine($"Price: {Price}");
        }
    }
}
