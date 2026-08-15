using System;
using System.Xml.Linq;


namespace Property
{
    internal class Employee
    {
            public int Id { get; private set; }
            public string Name { get; set; }

            private double salary;
            public double Salary {

                get {
                    return salary;
                }

                set {
                    if (value >= 0) {
                        salary = value;
                    }
                }
            }
            public double AnnualSalary => salary * 12;


        public Employee() {
            this.Id = 0;
            this.Name = "";
            this.Salary = 0.0;
        }

        public Employee(int id, string name, double salary) {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
        }
    }
}
