using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture203.Class_collection
{
    internal class Payment
    {
        public Payment() { }
        public Payment(Customer customer, double amount)
        {
            Customer = customer;
            Amount = amount;
            AmountRemaining = amount;
        }
        public Customer Customer { get; set; }
        public double Amount { get; set; }
        public double AmountRemaining { get; private set; }
        public DateTime PaymentDate { get; set; }
        public bool Status
        {
            get
            {
                return PaymentDate != null;
            }
        }
        public void SettlePayment(double paidAmount)
        {
            if (paidAmount >= AmountRemaining)
            {
                PaymentDate = DateTime.Now;
                AmountRemaining -= paidAmount;
            }
            else
            {
                Console.WriteLine("The amount paid is not enough");
                AmountRemaining -= paidAmount;
            }
        }

        public void PrintPayment()
        {
            Console.WriteLine($"Customer: {Customer.Name}");
            Console.WriteLine($"Amount: {Amount}");
            Console.WriteLine($"Amount remaining: {AmountRemaining}");
            Console.WriteLine($"Payment date: {PaymentDate}");
        }
    }
}
