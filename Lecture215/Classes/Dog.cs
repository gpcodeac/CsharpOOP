using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture215.Classes
{
    internal class Dog : IAnimal, IMammal
    {
        private string _breed;

        public string Breed
        {
            get { return _breed; }
            set { _breed = value; }
        }

        public Dog(string breed = "")
        {
            Breed = breed;
        }

        public void Fight()
        {
            Console.WriteLine("Dog fights.");
        }

        public void Flee()
        {
            Console.WriteLine("Dog runs away.");
        }

        public void Feed()
        {
            Console.WriteLine("Dog eats.");
        }

        public void Mate()
        {
            Console.WriteLine("Dog breeds.");
        }

        public void GiveBirth()
        {
            Console.WriteLine("Dog produces puppies.");
        }

        public void Bark()
        {
            Console.WriteLine("Dog says woof.");
        }

        public string ToString()
        {
            return $"Class is 'Dog'. Breed is {Breed}";
        }

        public int CompareTo(IAnimal? other)
        {
            if (other == null) return 1;
            if (other == this) return 0;
            if (other is IMammal)
            {
                Console.WriteLine($"This.name: {this.GetType().Name}");
                Console.WriteLine($"Other.name: {other.GetType().Name}");
                return this.GetType().Name.CompareTo(other.GetType().Name);
            }
            if (other is IAnimal)
            {
                Console.WriteLine($"This.name pt2: {this.GetType().Name}");
                Console.WriteLine($"Other.name pt2: {other.GetType().Name}");
                return this.GetType().Name.CompareTo(other.GetType().Name);
            }
            if (other is not IAnimal)
            {
                throw new ArgumentException("Object is not an animal");
            }
            return 0;
        }
    }
}
