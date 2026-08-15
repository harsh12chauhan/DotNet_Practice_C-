using System;


namespace Static {

    internal class Program {

        public static void Main(string[] args) { 

            Employee emp1 = new Employee(1,"harsh",40000);
            Employee emp2 = new Employee(2,"thinkpad",70000);
            Employee emp3 = new Employee(3,"kapda",60000);

            Console.WriteLine(emp1);
            Console.WriteLine(emp2);
            Console.WriteLine(emp3);

            Console.WriteLine($"Total employee's: {Employee.GetEmployeeCount()}");

            Employee emp4 = new Employee(4, "turturiya", 6000);

            Console.WriteLine(emp4);
            Console.WriteLine($"Total employee's: {Employee.GetEmployeeCount()}");

        } 

    }
}
