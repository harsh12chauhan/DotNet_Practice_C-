namespace ValueTypesAndReferenceTypes
{

    internal class Program
    {

        public static void Main(string[] args)
        {

            //Employee employee = new Employee { Name = "Harsh", Salary = 40000 };     // Object Initialization
            //Console.WriteLine("orignal " + employee.Salary);

            //Employee emp2 = employee;
            //emp2.Salary = 20000;

            //Console.WriteLine("refered " + employee.Salary);

            // ref Example 
            //double salary = 50000;
            //Console.WriteLine("employee salary " + salary);

            //Employee.IncreaseSalary(salary);
            //Console.WriteLine("salary incremented " + salary);

            //Employee.IncreaseSalary(ref salary);
            //Console.WriteLine("salary incremented " + salary);


            // out Example 
            //double salary = 50000;
            //double bonus = 0;
            //Console.WriteLine($"salary incremented { salary } with bonus {bonus}" );

            //bool result = Employee.CalculateBonus(salary,out bonus);
            //Console.WriteLine($"salary incremented { salary } with bonus {bonus} => [{result}]" );

            // in Example 
            //Employee employee = new Employee { Name = "Harsh", Salary = 40000 };
            //Employee.DisplayEmployee(in employee);

            //Console.WriteLine(employee.Salary);

            // why above is working this should give me compilation error as i shouldn't
            // change the value of salary from DisplayEmplyee method

            // TryParser
            //string input = "50000";
            string input = "hello";

            int output;

            bool result = int.TryParse(input,out output);
            Console.WriteLine($"output initialized {output} => [{result}]" );

        }
    }

}
