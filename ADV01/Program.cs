using ADV01.BaseClassConstraint;
using ADV01.GenericInterfaces;
using ADV01.InterfaceConstraint;
using ADV01.MultipleConstraints;
using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Data;
using System.Reflection.Metadata;

namespace ADV01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01
            // Q1: What is a generic class? Why use generics?

            // Generics allow you to write classes the actual type is specified when the code is used(compile time) not when it is written
            // and we use it for code reuseability (instead of writing the same code for each type), cleaner code, type safety (catch type mismatches)
            #endregion

            #region Question 02
            //Container<double> container = new Container<double>();
            //container.Add(1.568);
            //container.Add(2.397);
            //container.Add(3.412);
            //Console.WriteLine(container.Get(1));
            #endregion

            #region Question 03
            //Pair<int, string> pair = new Pair<int, string>(30000, "Dareen");
            //pair.Show();
            #endregion

            #region Question 04
            //Q4: What is a generic method? Write Swap<T> method.

            //Generics allow you to write methods the actual type is specified when the code is used(compile time) not when it is written
            //int x = 5;
            //int y = 10;
            //Console.WriteLine($"Before Swap: X = {x}, Y = {y}");
            //Swap<int>( ref x, ref y );
            //Console.WriteLine($"After Swap: X = {x}, Y = {y}");
            #endregion

            #region Question 05
            //Q5: Write a generic method FindMax < T > that finds maximum value

            //int[] array = { 5, 7, 9, 10, 1 };
            //Console.WriteLine($"Max Value: {FindMax<int>(array)}");
            #endregion

            #region Question 06
            //Q6: What is a generic interface? Write IRepository<T>. 

            //Employee emp1 = new Employee(1, "Ahmed",40000);
            //Employee emp2 = new Employee(2, "Kareem", 785000);
            //Employee emp3 = new Employee(3, "Islam", 5000);
            //EmployeeRepo repo1 = new EmployeeRepo();
            //repo1.AddPerson(emp1);
            //repo1.AddPerson(emp2);
            //repo1.AddPerson(emp3);
            //Console.WriteLine("=========== Delete ID 1 and show all the employees ===========");
            //repo1.DeleteByID(1);
            //List<Employee> employees = repo1.GetAll();
            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}
            //Console.WriteLine($"\nFind Employee by ID: {repo1.GetById(2)}");
            #endregion

            #region Question 07
            //Q7: What is the 'struct' constraint? Write an example.

            // Constraints allow you to specify which types can be used as type arguments for a generic type 
            // So The struct constraint allows only value types but Reference types are not allowed.
            //Constraint<int> Structconstraint = new Constraint<int>(1);
            //Structconstraint.print();

            //Constraint<String> Structconstraint2 = new Constraint<String>("Error"); // Will cause error cuz Sring is refernce type
            #endregion

            #region Question 08
            //Q8: What is the 'class' constraint? Write an example

            // Constraints allow you to specify which types can be used as type arguments for a generic type 
            // So The Class constraint allows only Reference types but value types are not allowed.
            //Constraint<String> Classconstraint = new Constraint<String>("Hi");
            //Classconstraint.print();

            //Constraint<int> Classconstraint2 = new Constraint<int>(1); // Will cause an error cuz int is value type
            #endregion

            #region Question 09
            //Q9: What is the 'new()' constraint? Write an example.

            //The new() constraint requires that the type has a public parameterless(default) constructor It allows you to create new instances of T using new T()
            //Constraint<Product> Newconstraint = new Constraint<Product>(new Product());
            //Newconstraint.print();
            #endregion

            #region Question 10
            //Q10:  What is the interface constraint? Write an example.

            //The interface constraint requires that the type implements the specified interface The type argument must implement that interface (directly or indirectly)
            //PrintStudents<Student> s1 = new PrintStudents<Student>();
            //s1.PrintStudent(new Student(1, "Dareen", 4));
            #endregion

            #region Question 11
            //Q11: What is the base class constraint? Write an example.

            //PrintInfo<Jobs> p1 = new PrintInfo<Jobs>();
            //p1.Create(new Jobs(1, "Ahmed", "Doctor"));
            //p1.Create(new Jobs(2, "Malak", "Engineer"));
            //p1.Create(new Jobs(3, "Mona", "Nurse"));
            //p1.ShowAll();
            #endregion

            #region Question 12
            //Q12: How do you apply multiple constraints? Write an example. 

            //Combining multiple constraints to further restrict the types the order of constraints matters
            //CRUD<HourlyEmployee> C1 = new CRUD<HourlyEmployee>();
            //Console.WriteLine("===========Hourly Employees===========");
            //C1.Create(new HourlyEmployee(1, "Ahmed", 100));
            //C1.Create(new HourlyEmployee(2, "Nour", 500));
            //C1.Delete(2);
            //C1.GetAll();
            //Console.WriteLine("===========Monthly Employees===========");
            //CRUD<MonthlyEmployee> C2 = new CRUD<MonthlyEmployee>();
            //C2.Create(new MonthlyEmployee(1, "Dareen", 100000));
            //C2.Create(new MonthlyEmployee(2, "Kareem", 500000));
            //C2.Create(new MonthlyEmployee(3, "Hana", 7000));
            //C2.Update(3, "Lina");
            //C2.GetAll();
            //Console.WriteLine("===========Compare ID===========");
            //HourlyEmployee h1 = C1.GetById(1);
            //MonthlyEmployee m1 = C2.GetById(1);
            //Console.WriteLine(h1.CompareTo(m1));
            #endregion

            #region Question 13
            //Q13: What does the 'default' keyword do in generics ?

            // The default keyword returns the default value of a generic type
            // 0 for numerical types - null for reference types/ nullable value types - false for boolean
            #endregion

            #region Question 14
            // Q14: Write a SafeList<T> that returns default when the index is invalid.

            //SafeList<int> s1 = new SafeList<int>();
            //Console.WriteLine(s1.GetElementAt(0));
            #endregion

            #region Question 15
            //Q15: What is covariance? Explain the 'out' keyword.

            //Covariance uses out, the out keyword to specify that the type parameter is used only as output (return type)
            //Derived --> Base
            #endregion

            #region Question 16
            //Q16: What is contravariance? Explain the 'in' keyword.

            //Contravariance uses in, the in keyword to specify that the type parameter is used only as input (in parameter).
            //Base --> Derived
            #endregion

            #region Question 17
            //Q17: What is the difference between covariance and contravariance?

            //Covariance uses out and allows derived--->base 
            //Contravariance uses in and allows base--->derived 
            #endregion

            #region Question 18
            //Q18: How do static members work in generic types?

            //Every new Generic type creates new independent static members
            // ex: The static member called count for int can be number for string can be a different number
            #endregion

            #region Question 19
            //Q19: How can you inherit from a generic class?

            //Derived<T> inherits from Base<T> with the same type parameter T Whatever type T is (int, string,DateTime, ... ) it is used in both base and derived classes
            #endregion

            #region Question 20
            //Q20: Complete Exercise - Create a generic Cache<TKey, TValue>with Add, Get, Remove, Contains, and expiration support. 

            //Cache<int,string> c1 = new Cache<int, string>();
            //c1.Add(1, "Dareen");
            //c1.Add(2, "Ali");
            //c1.Add(3, "Mohamed");
            //Console.WriteLine(c1.GetByKey(1));
            //Console.WriteLine($"Does it cointain key 2? {c1.Contains(2)}");
            //c1.Remove(1);
            //Console.WriteLine($"Does it cointain key 1? {c1.Contains(1)}");
            #endregion
        }

        #region Methods
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static T FindMax<T>(T[] items) where T : IComparable<T>
        {
            if (items is not null && items.Length > 0)
            {
                T maxValue = items[0];  
                for (int i = 1; i < items.Length; i++)
                {
                    if (items[i].CompareTo(maxValue) > 0)
                        maxValue = items[i];
                }
                return maxValue;
            }

            return default;
        }
        #endregion

    }
}