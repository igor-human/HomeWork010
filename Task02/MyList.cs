using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public class MyList<T>
    {
        private T[] _items;
        private int _count;

        public MyList()
        {
            _items = new T[4];
            _count = 0;
        }

        public void Add(T item)
        {
            if(_count == _items.Length)
            {
                Array.Resize(ref _items, _items.Length + 5);
            }
            _items[_count] = item;
            _count++;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= _count)
                {
                    throw new IndexOutOfRangeException("Індекс виходить за межі");
                }
                return _items[index];
            }
        }

        public int Count
        {
            get { return _count; }
        }
    }
}
