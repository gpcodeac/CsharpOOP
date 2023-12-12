using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture201
{
    internal class Store
    {
        public Store(string name)
        {
            Name = name;
            Products = new List<string>();
        }
        public Store(string name, int year, List<string> products)
        {
            Name = name;
            Year = year;
            Products = products;
        }

        public string Name { get; set; }
        public int Year { get; set; }
        public List<string> Products { get; set; }
    }
}
