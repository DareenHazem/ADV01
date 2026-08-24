using System;
using System.Collections.Generic;
using System.Text;

namespace ADV01.MultipleConstraints
{
    internal class Employees:IComparable<Employees>
    {
        public int IdEmployee { get; set; }
        public string Name { get; set; }

        public Employees(int idEmployee, string name)
        {
            IdEmployee = idEmployee;
            Name = name;
        }

        public int CompareTo(Employees? other)
        { 
            if(other == null || this== null) return -1;
            if(other.IdEmployee > this.IdEmployee)
            {
                return -1;
            }
            else if(other.IdEmployee < this.IdEmployee)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

    }
}
