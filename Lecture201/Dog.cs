using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture201
{
    internal class Dog
    {
        public Dog() { }

        public Dog(string name, string breed, int age, bool certificate, string parentName1, string parentName2)
        {
            Name = name;
            Breed = breed;
            Age = age;
            Certificate = certificate;
            ParentName1 = parentName1;
            ParentName2 = parentName2;
        }

        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public bool Certificate { get; set; }
        public string ParentName1 { get; set; }
        public string ParentName2 { get; set; }

    }
}
