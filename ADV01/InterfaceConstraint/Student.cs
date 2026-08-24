using ADV01.GenericInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADV01.InterfaceConstraint
{
    internal class Student : IPrintable
    {
        public int IdStudent { get; set; }
        public string Name { get; set; }
        public decimal Gpa { get; set; }

        public Student(int idStudent, string name, decimal gpa)
        {
            IdStudent = idStudent;
            Name = name;
            Gpa = gpa;
        }
        public void print()
        {
            Console.WriteLine($"ID Student: {IdStudent}, Name: {Name}, gpa: {Gpa}");
        }
    }
}
