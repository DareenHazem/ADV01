using System;
using System.Collections.Generic;
using System.Text;

namespace ADV01.InterfaceConstraint
{
    internal class PrintStudents<T> where T : IPrintable
    {
        public void PrintStudent(T student) {
            student.print();
        }
    }
}
