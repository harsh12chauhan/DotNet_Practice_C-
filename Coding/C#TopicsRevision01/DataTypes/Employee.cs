namespace DataTypes
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }
        public double Salary { get; set; }
        public bool IsActive { get; set; }

        public char Grade { get; set; }

        public DateTime JoiningDate { get; set; }

        public enum EmployeeStatus
        {
            Active,
            OnLeave,
            Resigner
        }
        public EmployeeStatus Status { get; set; }

    }
}
