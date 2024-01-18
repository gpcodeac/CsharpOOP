using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture215.Classes
{
    internal class Bass : IAnimal, IFish
    {
        public void Fight()
        {
            Console.WriteLine("Bass Fight");
        }

        public void Flee()
        {
            Console.WriteLine("Bass Flee");
        }

        public void Feed()
        {
            Console.WriteLine("Bass Feed");
        }

        public void Mate()
        {
            Console.WriteLine("Bass Mate");
        }

        public void Swim()
        {
            Console.WriteLine("Bass Swim");
        }

        public void Spawn()
        {
            Console.WriteLine("Bass Spawn");
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
