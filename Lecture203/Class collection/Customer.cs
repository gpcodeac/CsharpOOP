using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture203.Class_collection
{
    internal class Customer
    {
        public Customer() { }
        public Customer(string name, string address, string phone, bool isVip)
        {
            Name = name;
            Address = address;
            Phone = phone;
            IsVip = isVip;
        }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool IsVip { get; set; }
        public List<Payment> PaymentHistory { get; set; } = new();
        public List<Reservation> ReservationHistory { get; set; } = new();
        


        public Reservation? ReserveFleetUnit(FleetUnit fleetUnit)
        {
            if (fleetUnit.ActiveReservation)
            {
                Console.WriteLine("This fleet unit is already reserved");
                return null;
            }
            else
            {
                Reservation reservation = new Reservation(this, fleetUnit);
                reservation.Reserve();
                return reservation;
            }
        }

        public void EndReservation(Reservation reservation)
        {
            reservation.EndReservation();
            ReservationHistory.Add(reservation);
            RequestPayment(reservation.Price);
        }

        private void RequestPayment(double amount)
        {
            Payment payment = new Payment(this, amount);
            AddPayment(payment);
        }
        public void AddPayment(Payment payment)
        {
            PaymentHistory.Add(payment);
        }

        public void SettlePayment(double paidAmount)
        {
            PaymentHistory[^1].SettlePayment(paidAmount);
        }

    }
}
