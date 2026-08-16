using Linq;

namespace FileHandling
{
    internal static class EmployeeData
    {

        public static List<Employee> GetEmployees()
        {

            List<Employee> empList = new List<Employee>{

                new Employee { Id = 1, Name = "Rahul", DepartmentId = 1, Department = "IT", Salary = 45000 },
                new Employee { Id = 2, Name = "Priya", DepartmentId = 2, Department = "HR", Salary = 55000 },
                new Employee { Id = 3, Name = "Amit", DepartmentId = 1, Department = "IT", Salary = 75000 },
                new Employee { Id = 4, Name = "Neha", DepartmentId = 3, Department = "Finance", Salary = 65000 },
                new Employee { Id = 5, Name = "Rohan", DepartmentId = 1, Department = "IT", Salary = 85000 },
                new Employee { Id = 6, Name = "Sneha", DepartmentId = 2, Department = "HR", Salary = 48000 },
                new Employee { Id = 7, Name = "Vikram", DepartmentId = 3, Department = "Finance", Salary = 72000 },
                new Employee { Id = 8, Name = "Anjali", DepartmentId = 4, Department = "Marketing", Salary = 58000 },
                new Employee { Id = 9, Name = "Karan", DepartmentId = 1, Department = "IT", Salary = 68000 },
                new Employee { Id = 10, Name = "Pooja", DepartmentId = 2, Department = "HR", Salary = 62000 },
                new Employee { Id = 11, Name = "Arjun", DepartmentId = 3, Department = "Finance", Salary = 78000 },
                new Employee { Id = 12, Name = "Kavita", DepartmentId = 4, Department = "Marketing", Salary = 54000 },
                new Employee { Id = 13, Name = "Suresh", DepartmentId = 1, Department = "IT", Salary = 92000 },
                new Employee { Id = 14, Name = "Meera", DepartmentId = 2, Department = "HR", Salary = 70000 },
                new Employee { Id = 15, Name = "Nikhil", DepartmentId = 3, Department = "Finance", Salary = 67000 },
                new Employee { Id = 16, Name = "Divya", DepartmentId = 4, Department = "Marketing", Salary = 63000 },
                new Employee { Id = 17, Name = "Manish", DepartmentId = 1, Department = "IT", Salary = 81000 },
                new Employee { Id = 18, Name = "Riya", DepartmentId = 2, Department = "HR", Salary = 59000 },
                new Employee { Id = 19, Name = "Deepak", DepartmentId = 3, Department = "Finance", Salary = 88000 },
                new Employee { Id = 20, Name = "Swati", DepartmentId = 4, Department = "Marketing", Salary = 76000 },

                };

            return empList;
        }

        public static void Display<T>(this IEnumerable<T> _items) {

            foreach (var item in _items) {

                Console.WriteLine(item);
            }
        }
    }
}
