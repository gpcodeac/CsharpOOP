using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture202.Class_collection
{
    internal class Computer
    {
        public Computer() { }
        public Computer(string name, string brand, double RAM, double storage)
        {
            Name = name;
            Brand = brand;
            this.RAM = RAM;
            Storage = storage;
        }
        public string Name { get; set; }
        public string Brand { get; set; }
        public double RAM { get; set; }
        public double Storage { get; set; }

        public bool CheckIfResourcesAreAvailable(double progRAM, double progStorage)
        {
            if (RAM >= progRAM && Storage >= progStorage)
            {
                return true;
            }
            return false;
        }

    }
}
