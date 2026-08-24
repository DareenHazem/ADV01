using System;
using System.Collections.Generic;
using System.Text;

namespace ADV01
{
    internal class Cache<TKey, TValue>
    {
        List<TKey> Keys = new List<TKey>();
        List<TValue> Values = new List<TValue>();

        public void Add(TKey key, TValue value)
        {
            Keys.Add(key);
            Values.Add(value);
        }

        public TValue GetByKey(TKey key)
        {
            if (Values == null) return default;
            int index = Keys.IndexOf(key);
            if (index != -1)
            {
                return Values[index];
            }
            else
            {
                return default;
            }
        }

        public void Remove(TKey key)
        {
            if (Values == null) { return; }
            int index = Keys.IndexOf(key);
            if (index != -1)
            {
                Keys.RemoveAt(index);
                Values.RemoveAt(index);
            }
        }

        public bool Contains(TKey key)
        {
            return Keys.Contains(key);
        }
    }
}
