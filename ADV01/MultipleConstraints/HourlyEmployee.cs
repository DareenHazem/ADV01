using System;
using System.Collections.Generic;
using System.Text;

namespace ADV01.MultipleConstraints
{
    internal class HourlyEmployee : Employees
    {
        public decimal HourlyRate { get; set; }

        public HourlyEmployee():base(0," ")
        {
            HourlyRate = 0;
        }
        public HourlyEmployee(int idEmployee, string name, decimal hourlyRate) : base(idEmployee, name)
        {
            HourlyRate = hourlyRate;
        }
        public override string ToString()
        {
            return $"ID: {IdEmployee}, Name: {Name}, Hourly Rate: {HourlyRate}";
        }
    }
}
