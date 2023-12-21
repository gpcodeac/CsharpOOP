using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture205.Class_library
{
    internal class Dog : Animal
    {
        public sealed override string MaekeSound()
        {
            return "Woof";
        }
    }
}
