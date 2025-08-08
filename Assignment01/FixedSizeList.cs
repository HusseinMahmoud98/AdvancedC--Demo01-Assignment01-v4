using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    internal class FixedSizeList<T>
    {
        private List<T> list;
        public int Capacity { get; set; }

        public FixedSizeList(int capacity)
        {
            Capacity = capacity;
            list = new List<T>();
        }

        public void Add(T item)
        {
            if (Capacity > list.Count)
            {
                list.Add(item);
            }

            else
            {
                throw new Exception("The list is full");
            }
        }

        public T Get(int index)
        {
            if (index < list?.Count && index >= 0)
            {
                return list[index];
            }

            else
            {
                throw new Exception("invalid index");
            }
        }
    }
}
