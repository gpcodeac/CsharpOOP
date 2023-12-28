using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture207.Classes
{
    internal class Validation2
    {
        public static void Validate<T>(T value)
        {
            if (value == null)
            {
                //throw new ArgumentNullException("NULL VALUE!!!!");
                Console.WriteLine($"Value is NULL.");
            }
            else
            {
                Console.WriteLine($"Type is '{value.GetType().Name}'. Value is '{value}'.");
            }
        }
    }
}
