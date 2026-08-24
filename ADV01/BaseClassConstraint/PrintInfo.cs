using System;
using System.Collections.Generic;
using System.Text;

namespace ADV01.BaseClassConstraint
{
    internal class PrintInfo<T> where T : Person
    {
        public List<T> person = [];
        public void Create(T item)
        {
            person.Add(item);
        }

        public void ShowAll()
        {
            if (person.Count > 0)
            {
                foreach (T item in person)
                {
                    item.print();
                }
            }
        }


    }
}
