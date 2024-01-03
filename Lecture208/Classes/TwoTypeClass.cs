using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture208.Classes
{
    internal class TwoTypeClass<T, U>
    {
        private T _valueOfT;
        private U _valueOfU;

        public void SetT(T value)
        {
            _valueOfT = value;
        }
        public void SetU(U value)
        {
            _valueOfU = value;
        }
        public void DisplayT()
        {
            Console.WriteLine($"Type is '{_valueOfT.GetType().Name}'. Value is '{_valueOfT.ToString()}'.");
        }
        public void DisplayU()
        {
            Console.WriteLine($"Type is '{_valueOfU.GetType().Name}'. Value is '{_valueOfU.ToString()}'.");
        }
    }
}
