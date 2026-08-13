using EmployeeManagementSystem.Employees;

namespace EmployeeManagementSystem
{

    internal class Program
    {

        public static void Main(string[] args)
        {

            //Developer dev = new Developer("harsh", 230000, "c#");
            //dev.Work();

            //Employee emp = dev;
            //emp.Work();

            // 1D Array
            Employee[] employee = new Employee[5];

            employee[0] = new Developer("harsh", 230000, "c#");
            employee[1] = new Developer("sagar", 30000, "sql");
            employee[2] = new Developer("yogesh", 70000, "docker");
            employee[3] = new Manager("Atul", 120000, 4);
            employee[4] = new Manager("Nelufar", 130000, 2);


            //foreach (Employee emp in employee)
            //{
            //    emp.DisplayEmployeeInfo();
            //}

            //2D Array
            int[,] Performance = new int[5, 3];

            for (int i = 0; i < Performance.GetLength(0); i++)
            {
                for (int j = 0; j < Performance.GetLength(1); j++)
                {
                    Performance[i, j] = employee[i].CalculateAveragePerformance(j);                    
                }
            }

            for (int i = 0; i < Performance.GetLength(0); i++)
            {
                for (int j = 0; j < Performance.GetLength(1); j++)
                {                    
                    Console.WriteLine($"Employee{i} {Performance[i, j]}");
                }
            }

            //Jagged array

            Employee[][] departmentEmployees = new Department[2][];

        }
    }

}