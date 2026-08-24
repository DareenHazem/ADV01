using System;
using System.Collections.Generic;
using System.Text;

namespace ADV01
{
    internal class Container<T>
    {
        List<T> values = new List<T>();

        public void Add(T value)
        {
            values.Add(value);
        }

        public T Get(int index)
        {
            return values[index];
        }

    }
}
