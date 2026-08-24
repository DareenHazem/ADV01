using System;
using System.Collections.Generic;
using System.Text;

namespace ADV01.BaseClassConstraint
{
    internal abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public abstract void print();
    }
}
