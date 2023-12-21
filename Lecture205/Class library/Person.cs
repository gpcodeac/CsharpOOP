using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture205.Class_library
{
    internal class Person
    {
        private string name;
        private string surname;
        private int yearOfBirth;
        protected string Name { get => name; private set { name = value; } }
        protected string Surname { get => surname; private set { surname = value; } }
        protected int YearOfBirth { get => yearOfBirth; private set { yearOfBirth = value; } }

        public Person(string name, string surname, int yearOfBirth)
        {
            Name = name;
            Surname = surname;
            YearOfBirth = yearOfBirth;
        }

        protected virtual void PrintInfo()
        {
            Console.WriteLine($"{Name} {Surname} {YearOfBirth}");
        }

        
    }
}
