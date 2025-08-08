using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class MultiBox<T>
    {
        public List<T> Box { get; set; }
        public MultiBox()
        {
            Box = new List<T>();
        }

        public void InsertItem(T item)
        {
            Box.Add(item);
        }

        public List<T> GetAllItems()
        {
            return Box;
        }

        public int Count()
        {
            return Box.Count;
        }

        public bool IsEmpty()
        {
            return Box?.Count == 0;
        }

    }
}
