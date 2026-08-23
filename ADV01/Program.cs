using System.ComponentModel;

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
        }

        #region Methods
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        #endregion

    }
}