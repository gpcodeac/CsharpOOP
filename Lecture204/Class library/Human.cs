using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture204.Class_library
{
    internal abstract class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();

        public Human(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public void AddVehicle(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
        }
    }
}
