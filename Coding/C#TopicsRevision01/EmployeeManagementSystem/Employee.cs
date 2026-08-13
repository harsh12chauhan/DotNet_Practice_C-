namespace EmployeeManagementSystem
{
    internal abstract class Employee
    {
        private static int IDGENERATOR = 1;
        public int Id { get; private set; }

        public string Name { get; set; }

        public double Salary { get; set; }

        protected Employee(string name, double salary) {

            Id = IDGENERATOR++;
            Name = name;
            Salary = salary;

        }

        public abstract double CalculateBonus();

        public virtual void DisplayEmployeeInfo() {

            Console.WriteLine($"Employee Id: {Id}");
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"Employee Salary: {Salary}");
        }

        public void Work() { 
        
            Console.WriteLine("Employee working...");
        }

        public abstract int CalculateAveragePerformance(int month);
    }
}
