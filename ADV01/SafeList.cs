using System;
using System.Collections.Generic;
using System.Text;

namespace ADV01
{
    internal class SafeList<T>
    {
       public List<T> safelist = new List<T>();

        public void Add(T item)
        {
            safelist.Add(item);
        }

        public T GetElementAt(int index)   
        {
            if (index >= 0 && index < safelist.Count)
            {
                return safelist[index];
            }
            return default(T);
        }
    }
}
