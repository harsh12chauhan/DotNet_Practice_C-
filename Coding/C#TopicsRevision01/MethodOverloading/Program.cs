using System;

namespace MethodOverloading {

    internal class Program {

        public static void Main(string[] args) {

            Calculator cal = new Calculator();

            Console.WriteLine(cal.Calculate(2,3));
            Console.WriteLine(cal.Calculate(4.2,3.3));
            Console.WriteLine(cal.Calculate(2,3,5));
            
        }
    }

}
