using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture208.Classes
{
    internal class Team<T> where T : Sport
    {
        public string Name { get; set; }
        public int YearOfEstablishment { get; set; }
        public int NumberOfMembers { get; set; }

        public Team()
        {
        }

        public Team(string name, int yearOfEstablishment, int numberOfMembers)
        {
            Name = name;
            YearOfEstablishment = yearOfEstablishment;
            NumberOfMembers = numberOfMembers;
        }

    }
}
