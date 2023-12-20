using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture204.Class_library
{
    internal class BusinessPerson : Human
    {
        public BusinessPerson(string name, string surname) : base(name, surname)
        {
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Surname: {Surname}");
            Console.WriteLine($"Vehicles:");
            foreach (var vehicle in Vehicles)
            {
                Console.WriteLine($"  {vehicle.GetType().Name}");
            }
        }
    }
}
