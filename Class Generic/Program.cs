using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Generic
{
    class Program
    {
        //  create a class generic "class = 'Box'"followed by generic = ' type parameter "<T>" '

        // <T> = allows it to store a value of any type specified when creating an instance of the class.
        public class Box<T>
        {
            public T Value { get; set; }
        }
        static void Main(string[] args)
        {
            // Create a Box to hold an integer

            Box<int> intBox = new Box<int>();
            intBox.Value = 123;
            Console.WriteLine($"Box contains: {intBox.Value}");

            // Create a Box to hold a string

            Box<string> stringBox = new Box<string>();
            stringBox.Value = "Hello, Generics!";
            Console.WriteLine($"Box contains: {stringBox.Value}");

            // Create a Box to hold a double

            Box<double> doubleBox = new Box<double>();
            doubleBox.Value = 45.67;
            Console.WriteLine($"Box contains: {doubleBox.Value}");
            Console.ReadKey();
        }
    
    }
}
