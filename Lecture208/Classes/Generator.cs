using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture208.Classes
{
    internal class Generator<T>
    {
        public static void Show(T value)
        {
            Console.WriteLine(value.ToString());
        }
    }
}
