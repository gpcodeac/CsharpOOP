using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture201
{
    internal class Cat
    {
        public Cat() { }

        public Cat(string name, string breed, int age, bool certificate)
        {
            Name = name;
            Breed = breed;
            Age = age;
            Certificate = certificate;
        }

        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public bool Certificate { get; set; }

    }
}
