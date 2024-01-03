using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture209.Classes
{
    internal class ReadOnlyList<T>
    {

        private readonly List<T> _list;

        public ReadOnlyList(List<T> list)
        {
            _list = list;
        }

        public T this[int index]
        {
            get
            {
                return _list[index];
            }
        }

        public int Count
        {
            get
            {
                return _list.Count;
            }
        }

        public void Print()
        {
            foreach (var item in _list)
            {
                Console.WriteLine(item);
            }
        }

        public T[] ToArray()
        {
            return _list.ToArray();
        }

        public T FindIfUnique(T item)
        {
            int index = _list.IndexOf(item);

            if(index == -1)
            {
                throw new Exception("The item is not in the list.");
            }

            if(index == _list.LastIndexOf(item))
            {
                return item;
            }
            else
            {
                throw new Exception("The item is not unique.");
            }
        }
            
        public T FindIfUniqueOrNone(T item)
        {
            int index = _list.IndexOf(item);

            if (index == -1)
            {
                T t = default;
                return t;
                //return default(T);
            }

            if (index == _list.LastIndexOf(item))
            {
                return item;
            }
            else
            {
                throw new Exception("The item is not unique.");
            }
        }

        public bool Contains(T item)
        {
            return _list.Contains(item);
        }
    }
}
