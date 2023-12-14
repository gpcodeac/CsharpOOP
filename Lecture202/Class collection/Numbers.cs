using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture202.Class_collection
{
    internal class Numbers
    {

        public Numbers() { }

        public void Add(int value)
        {
            NumberList.Add(value);
        }

        public void Print()
        {
            foreach (int value in NumberList) { Console.WriteLine(value); }
        }

        private List<int> NumberList { get; set; } = new();
    }
}
