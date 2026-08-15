namespace DataTypes
{

    internal class Program
    {

        public static void Main(string[] args)
        {

            Employee emp = new Employee
            {

                Id = 1,
                Name = "harsh",
                Age = 23,
                Salary = 50000,
                IsActive = false,
                Grade = 'A',
                //JoiningDate = 01/04/2025,
                Status = Employee.EmployeeStatus.Active
            };

            //var and dynamic
            var empName = emp.Name;
            var empAge = emp.Age;
            var empSalary = emp.Salary;
            var empStatus = emp.Status;

            Console.WriteLine(empName);
            Console.WriteLine(empAge);
            Console.WriteLine(empSalary);
            Console.WriteLine(empStatus);

            dynamic value = 10;
            Console.WriteLine(value);
            value = "hello";
            Console.WriteLine(value + $" Length {value.Length}");
            value = 34.99m;
            Console.WriteLine(value);

            // boxing and unboxing 
            int num = 20;
            Object obj = num;  // boxing
            Console.WriteLine(num);
            Console.WriteLine(obj);

            int newNum = (int)obj; // unboxing
            Console.WriteLine(newNum);

            // const and readonly
            Company company = new Company(2010);
            Console.WriteLine(company.foundationYear);
            // Console.WriteLine(company.companyName); // compiler is not allowed (const)
            Console.WriteLine(Company.companyName);  // (const) but allowed with class name

            Company company2 = new Company(2005);
            Console.WriteLine(company2.foundationYear);

            //company2.foundationYear = 3030; // not allowed

            // Console.WriteLine(company.companyName); // compiler is not allowed (const)
            Console.WriteLine(Company.companyName); //(const) but allowed with class name

            // Company.companyName = "XYZ-company"; // not allowed

            //double and decimal
            double sumDouble = 0.1 + 0.2;
            decimal sumDecimal = 0.1m + 0.2m;
            Console.WriteLine($"sumDouble:{sumDouble}");
            Console.WriteLine($"sumDecimal:{sumDecimal}");

            // Nullable types
            int? age = null;  // int? short hand for Nullable<int>
            //int? age = 20;

            if (age.HasValue)
            {
                Console.WriteLine($"age: {age}");
                Console.WriteLine($"age.value: {age.Value}");
                Console.WriteLine($"age.GetValueOrDefault: {age.GetValueOrDefault(30)}");
            }
            else
            {
                Console.WriteLine($"age.GetValueOrDefault: {age.GetValueOrDefault(30)}");
                Console.WriteLine($"age: null");
            }

            //Type conversion [parse throws error if wrong conversion while tryParse return false
            string val = "50000";
            //string val = "hello"; //error System.FormatException: 

            Console.WriteLine($"val: {val}");

            int i = int.Parse(val.ToString());
            Console.WriteLine($"i: {i}");

            double d = double.Parse(val.ToString());
            Console.WriteLine($"d: {d}");

            decimal deci = decimal.Parse(val.ToString());
            Console.WriteLine($"deci: {deci}");

            string tval = "68000";
            //string tval = "hello"; // return false and out value is set to 0

            int ti;
            bool result = int.TryParse(tval, out ti);
            Console.WriteLine($"ti: {ti}, result: {result}");

            double td; 
            bool dresult= double.TryParse(tval, out td);
            Console.WriteLine($"td: {td}, result: {dresult}");

            decimal tdeci;
            bool ddresult = decimal.TryParse(tval, out tdeci);
            Console.WriteLine($"tdeci: {tdeci}, result: {ddresult}");


        }
    }

}
