using System;
using System.Collections.Generic;
using System.Text;

namespace ADV01.GenericInterfaces
{
    internal class Employee
    {
        public int IdEmployee { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Employee(int idEmployee, string name, decimal salary)
        {
            IdEmployee = idEmployee;
            Name= name; 
            Salary = salary;
        }

        public override string ToString()
        {
            return $"ID Product: {IdEmployee}, Name: {Name}, Salary: {Salary}";
        }
    }
}
