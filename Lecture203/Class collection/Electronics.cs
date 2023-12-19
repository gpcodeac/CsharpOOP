using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture203.Class_collection
{
    internal class Electronics : Product
    {
        public string Warranty { get; set; }

        public Electronics(string name, double price, double quantity, string warranty) : base(name, price, quantity)
        {
            Warranty = warranty;
        }

        public Electronics()
        {
        }

        public void PrintProductInfo()
        {
            Console.WriteLine($"Name: {Name}, Price: {Price}, Quantity: {Quantity}, Warranty: {Warranty}");
        }
    }
}
