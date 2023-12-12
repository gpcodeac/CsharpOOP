using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture201
{
    internal class School
    {
        public School(string name, string city)
        {
            Name = name;
            City = city;
        }

        public School(string name, string city, int studentCount) : this(name, city)
        {
            StudentCount = studentCount;
        }


        public string Name { get; set; }
        public string City { get; set; }
        public int StudentCount { get; set; }

    }
}
