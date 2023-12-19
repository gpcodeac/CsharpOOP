using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture203.Class_collection
{
    internal class Food : Product
    {
        public DateTime ExpirationDate { get; set; }

        public Food(string name, double price, double quantity, DateTime expirationDate) : base(name, price, quantity)
        {
            ExpirationDate = expirationDate;
        }

        public Food()
        {
        }

        public void PrintProductInfo()
        {
            Console.WriteLine($"Name: {Name}, Price: {Price}, Quantity: {Quantity}, Expiration date: {ExpirationDate}");
        }
    }
}
