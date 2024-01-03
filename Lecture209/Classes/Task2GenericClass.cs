using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lecture209.Classes
{
    internal class Task2GenericClass<T>
    {
        private List<T> _list;

        public Task2GenericClass(List<T> list)
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

        public void Add(T item)
        {
            _list.Add(item);
        }

        public void Merge(Task2GenericClass<T> other)
        {
            _list.AddRange(other._list);
        }

        public void Merge(List<T> items)
        {
            _list.AddRange(items);
        }

        public void Remove(T item)
        {
            _list.Remove(item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        public void RemoveAll(T item)
        {
            _list = _list.Where(x => !x.Equals(item)).ToList();
        }
    }
}
