using ADV01.GenericInterfaces;
using ADV01.InterfaceConstraint;
using System.ComponentModel;
using System.Data;

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