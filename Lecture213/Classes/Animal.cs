using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture213.Classes
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name = "", int age = 0)
        {
            Name = name;
            Age = age;
        }

        public void PrintAnimal()
        {
            Console.WriteLine($"I am an animal and my name is {Name}. My age is {Age}");
        }
    }
}
