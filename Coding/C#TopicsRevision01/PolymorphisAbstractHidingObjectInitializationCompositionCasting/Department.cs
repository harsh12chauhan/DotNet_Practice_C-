using System;

namespace PolymorphisAbstractHidingObjectInitializationCompositionCasting
{
    internal class Department
    {

        public string DepartmentName { get; set; }
        private Manager DepartmentManager { get; }


        public Department(string departmentName, Manager departmentManage) {

            DepartmentName = departmentName;
            DepartmentManager = departmentManage;            
        }

        public void ShowDepartmentInfo() {

            Console.WriteLine($"DepartmentName : {DepartmentName}");
            //Console.WriteLine($"DepartmentManager : {DepartmentManager}");
            
            Console.WriteLine("Manager ");
            DepartmentManager.DisplayInfo();

        }
            
    }
}
