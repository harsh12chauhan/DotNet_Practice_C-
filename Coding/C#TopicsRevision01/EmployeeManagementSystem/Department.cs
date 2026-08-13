using EmployeeManagementSystem.Employees;

namespace EmployeeManagementSystem
{
    internal class Department
    {
        public readonly string? DepartmentName;

        private Manager DepartmentManager;
        public Department(Manager departmentManager) { 
            
            DepartmentManager = departmentManager;
        }

        public void ShowDepartmentInfo() {

            Console.WriteLine($"DepartmentName: {DepartmentName}");
            DepartmentManager.DisplayEmployeeInfo();
        }
    }
}
