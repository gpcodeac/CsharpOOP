using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture203.Class_collection
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }

        public Product(string name, double price, double quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public Product()
        {
        }

        public void PrintProductInfo()
        {
            Console.WriteLine($"Name: {Name}, Price: {Price}, Quantity: {Quantity}");
        }
    }
}
