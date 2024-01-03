using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture208.Classes
{
    internal class Type<T,U>
    {
        private T _valueOfT;
        private U _valueOfU;

        public Type()
        {
            _valueOfT = default;
            _valueOfU = default;
        }
        public Type(T valueOfT, U valueOfU)
        {
            _valueOfT = valueOfT;
            _valueOfU = valueOfU;
        }

        public string GetType<V>(V value)
        {
            return value.GetType().Name;
        }

        
    }
}
