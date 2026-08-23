using System;
using System.Collections.Generic;
using System.Text;

namespace ADV01.GenericInterfaces
{
    internal class EmployeeRepo : IRepository<Employee>
    {
        private List<Employee> Employees = new List<Employee>();
        public void AddPerson(Employee item)
        {
            Employees.Add(item);
        }
        public Employee GetById(int id)
        {
            foreach (Employee emp in Employees)
            {
                if (emp.IdEmployee == id)
                {
                    return emp;
                }
            }
            return default;
        }
        public void DeleteByID(int id)
        {
            Employee emp = GetById(id);
            Employees.Remove(emp);
        }
        public List<Employee> GetAll()
        {
            return Employees;
        }

    }
}

