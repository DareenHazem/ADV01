using ADV01.GenericInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADV01.MultipleConstraints
{
    internal class CRUD<T> where T : Employees,IComparable<Employees>, new()
    {
        List<T> list = new List<T>();

        public void Create(T item)
        {
            list.Add(item);
        }

        public void GetAll()
        {
            if (list.Count > 0)
            {
                foreach (T item in list)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public T GetById(int id)
        {
            foreach (T item in list)
            {
                if (item.IdEmployee == id)
                {
                    return item;
                }
            }
            return default;
        }
        public void Update(int id, string newName)
        {
            foreach (T item in list)
            {
                if (item.IdEmployee == id)
                {
                    item.Name = newName;
                    return;
                }
            }
        }
        public void Delete(int id)
        {
            T item = GetById(id);
            list.Remove(item);
        }

    }
}
