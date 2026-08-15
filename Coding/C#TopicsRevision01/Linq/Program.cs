namespace Linq
{
    internal class Program
    {

        public static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>{
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

            //Console.WriteLine("==== emps with sal > 60000 ================ ");
            //var emp = from e in employees where e.Salary > 60000 select e;  

            //foreach (var r in emp)
            //{
            //    Console.WriteLine(r);
            //}

            //Console.WriteLine("====== emps with dept:It sal > 60000 ============== ");
            //var emp1 = from e in employees where e.Department == "IT" && e.Salary > 60000 select new { e.Name, e.Salary };
            //var emp2 = from e in employees where e.Department.Contains("IT") && e.Salary > 60000 select e;

            //foreach (var r in emp1)
            //{
            //    Console.WriteLine(r);
            //}

            //Console.WriteLine("====== emps with dept:It sal > 60000 ============== ");
            //foreach (var r in emp2)
            //{
            //    Console.WriteLine(r);
            //}

            //Console.WriteLine("====== emps name and extension method ============== ");
            //var emp3 = from e in employees select new { e.Name };
            //emp3.Display();

            //Console.WriteLine("===== Quary syntax all emp name,sal and dept =============== ");
            //var emp4 = from e in employees select new { e.Name, e.Salary, e.Department };
            //foreach (var r in emp4)
            //{
            //    Console.WriteLine(r);
            //}

            //Console.WriteLine("===== method syntax all emp name,sal and dept =============== ");
            //var emp5 = employees.Where(e => e.Salary > 60000 && e.Department == "IT").Select(e => new { e.Name, e.Salary });

            //foreach (var r in emp5)
            //{
            //    Console.WriteLine(r);
            //}

            // Extension Method (Display is my own)
            //var empName = employees.Where(e => e.Name.StartsWith('N')).Select(e => new { e.Name, e.Salary });
            //empName.Display();

            // OrderBy, OrderByDescending, ThenBy , ThenByDescending  ---------
            //Console.WriteLine("== all emp in IT with salara > 50000, sort by high sal =============== ");

            //var empReport = employees
            //                .Where(e => e.Department == "IT" && e.Salary > 50000)
            //                .OrderByDescending(e => e.Salary)
            //                .ThenBy(e => e.Name)
            //                .Select(e => new { e.Name, e.Salary});

            //empReport.Display();


            // First, FirstOrDefault, Single, SingleOrDefault, Last, LastOrDefault -----------

            //var FirstItEmp = employees.Where(e => e.Department == "IT").First();
            //Console.WriteLine($"First IT employee: {FirstItEmp}");

            //var FirstItEmpShort = employees.First(e => e.Department == "IT");
            //var FirstItEmpShort = employees.First(); // this will give the first record of the employee list
            //Console.WriteLine($"First IT employee without using [where]: {FirstItEmpShort}");

            //var FindEmpById = employees.Where(e => e.Id == 3).SingleOrDefault();
            //Console.WriteLine($"Find employee by id 3: {FindEmpById}");

            //var NonExistingEmp = employees.Where(e => e.Name == "harsh").FirstOrDefault();
            //Console.WriteLine($"Non-Existing Emp: {NonExistingEmp}");

            //var LastHREmp = employees.Last(e => e.Department == "HR");
            //Console.WriteLine($"Last HR Emp: {LastHREmp}");

            //var NonExistingLastEmp = employees.LastOrDefault(e => e.Name == "harsh");
            //Console.WriteLine($"Non-Existing Last Emp: {NonExistingLastEmp}");

            // below will throw exception as Single is used but multiple entry of IT is present.
            //var TestExceptionSingle = employees.Single(e => e.Department == "IT");
            //Console.WriteLine($"This will throw exception: {TestExceptionSingle}");

            // Any, All, Contains

            //var IsITEmpExist = employees.Any(e => e.Department == "IT");
            //if (IsITEmpExist)
            //{
            //    Console.WriteLine("employee exist's");
            //}

            //var IsAnyEmpEarnMore = employees.Any(e => e.Salary > 90000);
            //if (!IsAnyEmpEarnMore)
            //{
            //    Console.WriteLine("no employee earn more then 90000");
            //}

            //var IsEveryEmpEarnMore = employees.All(e => e.Salary > 40000);
            //if (IsEveryEmpEarnMore)
            //{
            //    Console.WriteLine("every employee earn more then 40000");
            //}

            //var IsEveryEmpIsfromIT = employees.All(e => e.Department == "IT");
            //if (IsEveryEmpIsfromIT)
            //{
            //    Console.WriteLine("every employee is from IT ");
            //}

            //List<string> allowedDepartments = new List<string>
            //{
            //    "IT",
            //    "HR",
            //    "Finance"
            //};

            //var IsITDeptExist = allowedDepartments.Contains("IT");
            //if (IsITDeptExist)
            //{
            //    Console.WriteLine(" IT dept exists ");
            //}

            // Aggregation:  Count(), Sum(), Average(), Min(), Max() ----------

            //var totalEmp = employees.Count();
            //Console.WriteLine($"total employee: {totalEmp}");

            //var totalItEmp = employees.Count(e => e.Department == "IT");
            //Console.WriteLine($"total employee in IT {totalItEmp} ");

            //var totalSalaryPaid = employees.Sum(e => e.Salary);
            //Console.WriteLine($"total salary paid to employee {totalSalaryPaid} ");

            //var totalAvgSalaryPaid = employees.Average(e => e.Salary);
            //Console.WriteLine($"avg salary paid: {totalAvgSalaryPaid} ");

            //var lowestSalaryPaid = employees.Min(e => e.Salary);
            //Console.WriteLine($"lowest salary paid: {lowestSalaryPaid} ");

            //var highestSalaryPaid = employees.Max(e => e.Salary);
            //Console.WriteLine($"highest salary paid: {highestSalaryPaid} ");

            //var EmpWithLowestSalaryPaid = employees.MinBy(e => e.Salary);
            //Console.WriteLine($"emp with lowest salary paid: {EmpWithLowestSalaryPaid} ");

            //var EmpWithHighestSalaryPaid = employees.MaxBy(e => e.Salary);
            //Console.WriteLine($"emp with highest salary paid: {EmpWithHighestSalaryPaid} ");

            // Groupby, 
            //var EmpGroupedByDeptName = employees.GroupBy(e => e.Department);

            //foreach (var group in EmpGroupedByDeptName)
            //{
            //    Console.WriteLine($"Department: {group.Key}");
            //    foreach (var emp in group)
            //    {
            //        Console.WriteLine($"  {emp.Name}");
            //    }
            //}

            // Group by with aggeration methods
            //var EmpGroupedByDeptNameOpt = employees.GroupBy(e => e.Department)
            //                            .Select(g => new
            //                            {
            //                                Department = g.Key,
            //                                EmployeeCount = g.Count(),
            //                                TotalSalary = g.Sum(e => e.Salary),
            //                                AverageSalary = g.Sum(e => e.Salary)

            //                            });

            //foreach (var dept in EmpGroupedByDeptNameOpt)
            //{
            //    Console.WriteLine(
            //        $"{dept.Department} - " +
            //        $"Employees: {dept.EmployeeCount}, " +
            //        $"Total: {dept.TotalSalary}, " +
            //        $"Average: {dept.AverageSalary}"
            //    );
            //}

            // ------------------------------------------------------------------------------
            // distinct,skip ,take, union, intersect,except,concat, tolist,toarray,todictonary,
            // join, deffer execution and immidiate execution,iEnumerable and IQueryable,
            // ------------------------------------------------------------------------------

            //var uniqueDepartments = employees.Select(e => e.Department).Distinct();
            //Console.WriteLine($"unique departments: {string.Join(", ", uniqueDepartments)}");

            //var skippedEmployees = employees.Skip(2);
            //Console.WriteLine($"employees after skipping 2: {string.Join(", ", skippedEmployees.Select(e => e.Name))}");

            //var firstThreeEmployees = employees.Take(3);
            //Console.WriteLine($"first 3 employees: {string.Join(", ", firstThreeEmployees.Select(e => e.Name))}");

            //var list1 = new[] { 1, 2, 3, 4 };
            //var list2 = new[] { 3, 4, 5, 6 };


            //var unionResult = list1.Union(list2);
            //Console.WriteLine($"union: {string.Join(", ", unionResult)}");

            //var intersectResult = list1.Intersect(list2);
            //Console.WriteLine($"intersect: {string.Join(", ", intersectResult)}");

            //var exceptResult = list1.Except(list2);
            //Console.WriteLine($"except: {string.Join(", ", exceptResult)}");

            //var concatResult = list1.Concat(list2);
            //Console.WriteLine($"concat: {string.Join(", ", concatResult)}");

            //var employeeList = employees.Where(e => e.Salary > 60000).ToList();
            //Console.WriteLine($"employees as List: {employeeList.Count}");

            //var employeeArray = employees.Where(e => e.Salary > 60000).ToArray();
            //Console.WriteLine($"employees as Array: {employeeArray.Length}");

            //var employeeDictionary = employees.ToDictionary(e => e.Id);
            //Console.WriteLine($"employee with ID 3: {employeeDictionary[3].Name}");


            // Joins
            //List<Department> departments = new List<Department>
            //        {
            //            new Department { DepartmentId = 1, DepartmentName = "IT", Budget = 5000000 },
            //            new Department { DepartmentId = 2, DepartmentName = "HR", Budget = 2500000 },
            //            new Department { DepartmentId = 3, DepartmentName = "Finance", Budget = 3500000 }
            //        };

            //var employeeDepartments = employees.Join(
            //    departments,
            //    e => e.DepartmentId,
            //    d => d.DepartmentId,
            //    (e, d) => new 
            //    { 
            //        EmpName = e.Name, 
            //        Department = d.DepartmentName,
            //        DepartmentBudget = d.Budget 
            //    }
            //);

            //foreach (var e in employeeDepartments)
            //{
            //    Console.WriteLine($"{e.EmpName} - {e.Department}:{e.DepartmentBudget}");
            //}

            // Deffer execution

            var deferredQuery = employees.Where(e => e.Salary > 60000);

            employees.Add(new Employee
            {
                Id = 7,
                Name = "Raj",
                Department = "IT",
                Salary = 90000
            });
            Console.WriteLine($"deferred query count: {deferredQuery.Count()}");

            // Immediate Execution
            var immediateQuery = employees
                .Where(e => e.Salary > 60000)
                .ToList();

            employees.Add(new Employee
            {
                Id = 8,
                Name = "Vikram",
                Department = "IT",
                Salary = 95000
            });
            Console.WriteLine($"immediate query count: {immediateQuery.Count}");


            IEnumerable<Employee> enumerableEmployees = employees.Where(e => e.Salary > 60000);
            Console.WriteLine($"IEnumerable count: {enumerableEmployees.Count()}");


            IQueryable<Employee> queryableEmployees = employees.AsQueryable().Where(e => e.Salary > 60000);
            Console.WriteLine($"IQueryable count: {queryableEmployees.Count()}");

        }
    }
}


