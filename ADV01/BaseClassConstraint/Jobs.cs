using ADV01.GenericInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADV01.BaseClassConstraint
{
    internal class Jobs : Person
    {
        public string Job {  get; set; }
        public Jobs(int id, string name, string job) : base(id, name)
        {
            Job= job;
        }

        public override void print()
        {
            Console.WriteLine($"ID Product: {Id}, Name: {Name}, Job: {Job}");
        }
    }
}
