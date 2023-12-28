using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture207.Classes
{
    internal class MyList<T> : List<T>
    {
        public void RemoveItem(T value)
        {
            foreach (var item in this)
            {
                if (item.Equals(value))
                {
                    Remove(item);
                    Console.WriteLine($"Item was removed.");
                    break;
                }
            }
        }

        public void RemoveItemFromArr(T value)
        {
            for (int i = 0; i < Count; i++)
            {
                if (this[i].Equals(value))
                {
                    RemoveAt(i);
                    Console.WriteLine($"Item was removed.");
                    break;
                }
            }
        }
    }
}
