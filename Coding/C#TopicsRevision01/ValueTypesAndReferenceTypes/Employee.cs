using System;
using System.Data;

namespace ValueTypesAndReferenceTypes
{
    internal class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public static void IncreaseSalary(double amount)
        {
            amount += 10000;
        }

        public static void IncreaseSalary(ref double amount) {

            amount += 10000;
            
        }

        public static bool CalculateBonus(double salary, out double bonus) {

            if (salary >= 100000) {
                bonus = salary * 30 / 100;
                return true;
            }
            
            if (salary < 100000) {
                bonus = salary * 10 / 100;
                return true;
            }
            
            bonus = 0;

            return false;
        }

        public static void DisplayEmployee(in Employee emp) {

            Console.WriteLine(emp.Name);
            Console.WriteLine(emp.Salary);
            
            emp.Salary = 0;

        }

    }
}
