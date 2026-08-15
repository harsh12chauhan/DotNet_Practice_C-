namespace Inheritance
{

    internal class Program
    {

        public static void Main(string[] args)
        {

            Manager manager = new Manager(1, "Atul", 100000, 4);
            Developer developer = new Developer(2, "Harsh", 40000, "c#");

            manager.DisplayInfo();
            developer.DisplayInfo();

            Developer javaDeveloper = new Developer(5, "Amit", 80000, "Java");

            javaDeveloper.DisplayInfo();


            Employee expertEmployee = new Developer(3, "gptbhai", 30000, "all languages");

            expertEmployee.DisplayInfo();


            Employee[] employees = new Employee[5];

            employees[0] = new Manager(4, "yogesh", 100000, 4);
            employees[1] = new Developer(6, "Amit", 80000, "Java");
            employees[2] = new Developer(2, "Harsh", 40000, "c#");
            employees[3] = new Developer(8, "sagar", 60000, "SQl");
            employees[4] = new Developer(7, "dhiraj", 150000, "powershell");


            foreach (Employee emp in employees)
            {
                Console.WriteLine("");
                emp.DisplayInfo();
                Console.WriteLine("");
            }




        }
    }

}
