using System;

namespace Inheritance
{
    internal class Employee
    {
        public int Id { get; private set; }
        public string Name { get;  set; }
        public double Salary { get; private set; }

        public Employee(): this(id:0,name:"unknown",salary:0.0) { }
        public Employee(int id, string name, double salary)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
        }

        public virtual void DisplayInfo() {

            Console.WriteLine($"Id : {Id}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Salary : {Salary}");

        }

    }
}
