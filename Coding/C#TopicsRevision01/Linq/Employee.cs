namespace Linq
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            return Id + " " + Name + " " + DepartmentId + " " + Department + " " + Salary;
        }
    }

}
