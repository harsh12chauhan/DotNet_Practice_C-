using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphisAbstractHidingObjectInitializationCompositionCasting
{
    internal abstract class Employee
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Salary { get; protected set; }

        protected Employee(int id, string name, double salary) { 
            Id = id;
            Name = name;
            Salary = salary;    
        }

        public abstract double CalculateBonus();


        public virtual void DisplayInfo() {

            Console.WriteLine($"Id : {Id}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Salary : {Salary}");
        }

        public void Work() { 
        
            Console.WriteLine("Employee is working...");
        }
    }
}
