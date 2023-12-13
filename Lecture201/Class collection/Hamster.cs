using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture201
{
    internal class Hamster
    {
        public Hamster() { }

        public Hamster(string name, string color, int ageInMonths)
        {
            Name = name;
            Color = color;
            AgeInMonths = ageInMonths;
        }

        public string Name { get; set; }
        public string Color { get; set; }
        public int AgeInMonths { get; set; }

    }
}
