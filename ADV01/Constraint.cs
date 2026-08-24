using System;
using System.Collections.Generic;
using System.Text;

namespace ADV01
{
    internal class Constraint<T> where T : class 
    {
        public T Value { get; set; }
        public Constraint(T value)
        {
            Value = value;
        }
        public void print()
        {
            Console.WriteLine($"Value: {Value}");
        }
    }
}
