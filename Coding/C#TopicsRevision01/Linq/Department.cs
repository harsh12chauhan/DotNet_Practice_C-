namespace Linq
{
    internal class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public double Budget { get; set; }

        public override string ToString()
        {
            return DepartmentId + " " + DepartmentName + " " + Budget;
        }
    }
}
