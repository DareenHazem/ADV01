using System;
using System.Collections.Generic;
using System.Text;

namespace ADV01.MultipleConstraints
{
    internal class MonthlyEmployee:Employees
    {
        decimal MonthlySalary {  get; set; }
        public MonthlyEmployee() : base(0, " ")
        {
            MonthlySalary = 0;
        }
        public MonthlyEmployee(int idEmployee, string name, decimal monthlySalary) : base(idEmployee, name)
        {
            MonthlySalary = monthlySalary;
        }
        public override string ToString()
        {
            return $"ID: {IdEmployee}, Name: {Name}, Monthly Salary: {MonthlySalary}";
        }
    }
}
