using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture213.Classes
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public List<Animal> listOfAnimals = new List<Animal>();

        public Person(string name = "", int age = 0)
        {
            Name = name;
            Age = age;
        }

        public void AddAnimal(Animal animal)
        {
            listOfAnimals.Add(animal);
        }

        public void RemoveAnimal(Animal animal)
        {
            listOfAnimals.Remove(animal);
        }

        public void PrintListOfAnimals()
        {
            Console.WriteLine($"List of animals for {Name}:");
            foreach (var animal in listOfAnimals)
            {
                Console.WriteLine(animal.Name);
            }
        }

        public void PrintPerson()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

    }
}
