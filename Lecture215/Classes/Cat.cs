using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture215.Classes
{
    internal class Cat : IMammal, IAnimal
    {
        public void Fight()
        {
            Console.WriteLine("Cat Fight");
        }

        public void Flee()
        {
            Console.WriteLine("Cat Flee");
        }

        public void Feed()
        {
            Console.WriteLine("Cat Feed");
        }

        public void Mate()
        {
            Console.WriteLine("Cat Mate");
        }

        public void GiveBirth()
        {
            Console.WriteLine("Cat GiveBirth");
        }

        public void Sleep()
        {
            Console.WriteLine("Cat Sleep");
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
