using System;

namespace Static
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        private static int EmployeeCount { get; set; }
        
        static Employee() { 
            EmployeeCount = 0;
        }

        public Employee(int id, string name, double salary) { 
            Id = id;
            Name = name;
            Salary = salary;
            EmployeeCount = EmployeeCount + 1;
        }

        public static int GetEmployeeCount() { 
            return EmployeeCount;
        }

        public override string ToString()
        {
            return Id + " " + Name + " " + Salary;
        }

    }
}
