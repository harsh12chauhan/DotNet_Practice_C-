namespace PolymorphisAbstractHidingObjectInitializationCompositionCasting
{

    internal class Program
    {

        public static void Main(string[] args)
        {

            Employee[] employee = new Employee[5];

            employee[0] = new Manager(1, "atul", 80000, 4);
            employee[1] = new Developer(2, "harsh", 130000, "c#");
            employee[2] = new Developer(3, "dhiraj", 120000, "powershell");
            employee[3] = new Developer(4, "dakshesh", 120000, "python");
            employee[4] = new Developer(5, "lokesh", 120000, "dotnet");


            foreach (var emp in employee)
            {
                Console.WriteLine("");
                emp.DisplayInfo();
                Console.WriteLine("");
            }

            // Hiding
            Developer dev = new Developer(6, "harsh", 230000, "java");
            dev.Work();

            Employee empdev = new Developer(7, "abhishek", 70000, "go");
            empdev.Work();


            // Upcasting 
            Employee e = new Developer(8, "namit", 32000, "angular");
            e.DisplayInfo();

            Employee m = new Manager(8, "namit", 132000, 7);
            m.DisplayInfo();

            // Downcasting
            //Developer d = e as Developer;
            Developer d = m as Developer;

            if (d is Developer)
            {
                d.DisplayInfo();
            }

            if (d is Manager)
            {
                d.DisplayInfo();
            }

            if (d != null)
            {
                d.DisplayInfo();
            }
            else
            {
                Console.WriteLine("developer is null");
            }

            Manager DevopsManager = new Manager(1, "atul", 80000, 4);

            Department dept = new Department("Devops", DevopsManager);
            dept.ShowDepartmentInfo();

            // Object initialization

            Manager manager = new Manager(12, "yogesh", 23000, 3)
            {
                Name = "Nelufar"
            };

            manager.DisplayInfo();
        }
    }

}
