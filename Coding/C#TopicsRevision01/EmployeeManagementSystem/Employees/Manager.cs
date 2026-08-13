namespace EmployeeManagementSystem.Employees
{
    internal class Manager: Employee, IWorkable
    {
        public int TeamSize { get; private set; }
        public Manager(string name, double salary,int teamsize): base(name,salary) 
        {                                         
            TeamSize = teamsize;
        }

        public override double CalculateBonus()
        {
            double bonus = Salary * 20 / 100;
            return bonus;
        }

        public override void DisplayEmployeeInfo()
        {
            base.DisplayEmployeeInfo();
            Console.WriteLine($"TeamSize: {TeamSize}");
        }

        public new void Work() 
        {            
            Console.WriteLine("Manager working...");
        }

        public override int CalculateAveragePerformance(int month)
        {
            int performance = (month * (int)Salary)%100;
            return performance;
        }
    }
}
