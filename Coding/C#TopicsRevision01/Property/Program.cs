using System;

namespace Property{

    internal class Program {

        public static void Main(string[] args) {

            Employee emp = new Employee(1,"chatgpt",40000);

            //  emp.Id = 2; not able to set

            Console.WriteLine(emp.Id);
            Console.WriteLine(emp.Name);

            emp.Name = "friend";
            Console.WriteLine(emp.Name);

            emp.Salary = emp.Salary + 10000;
            Console.WriteLine(emp.Salary);

            emp.Salary = -30000;
            Console.WriteLine(emp.Salary);

            Console.WriteLine(emp.AnnualSalary);

        }
    }

}
