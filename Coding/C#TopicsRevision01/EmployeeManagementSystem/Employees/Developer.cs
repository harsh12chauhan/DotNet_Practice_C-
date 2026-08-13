namespace EmployeeManagementSystem.Employees
{
    internal class Developer : Employee, IWorkable
    {
        public string ProgrammingLanguage { get; private set; }
        public Developer(string name, double salary, string programmingLanguage) : base(name, salary)
        {
            ProgrammingLanguage = programmingLanguage;
        }

        public override double CalculateBonus()
        {
            double bonus = Salary * 40 / 100;
            return bonus;
        }

        public override void DisplayEmployeeInfo()
        {
            base.DisplayEmployeeInfo();
            Console.WriteLine($"ProgrammingLanguage: {ProgrammingLanguage}");
        }

        public new void Work()
        {
            Console.WriteLine("Developer working...");
        }

        public override int CalculateAveragePerformance(int month)
        {
            int performance = (month * (int)Salary)%100;
            return performance;
        }
    }
}
