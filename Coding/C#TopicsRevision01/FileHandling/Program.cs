using Linq;
using System.Formats.Asn1;
using System.Text.Json;

namespace FileHandling
{
    internal class Program
    {

        public static void MyStreamWriter(string filePath, string[] lines)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string line in lines)
                {
                    writer.WriteLine(line);
                }
            }
        }

        public static void MyStreamReader(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string? line;

                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }

        public static void WriteAllSerlizedObjectsToFile(string path, List<Employee> emps)
        {
            string jsonWriter = JsonSerializer.Serialize(emps);
            File.WriteAllText(path, jsonWriter);
        }
        public static void WriteSerlizedObjectsToFile(string path, Employee emp)
        {
            string jsonWriter = JsonSerializer.Serialize(emp);
            File.AppendAllText(path, jsonWriter);
        }

        public static void ReadAllSerlizedObjectsFromFile(string path)
        {
            string json = File.ReadAllText(path);
            List<Employee>? allEmp = JsonSerializer.Deserialize<List<Employee>>(json);

            if (allEmp != null && allEmp.Count > 0)
            {
                allEmp.Display();
            }
        }
        public static void Main(string[] args)
        {

            List<Employee> employees = EmployeeData.GetEmployees();

            //employees.Display();

            string mypath = "C:\\Users\\harsh\\Desktop\\Dotnet\\hello\\";

            //Directory.CreateDirectory(mypath);
            //Console.WriteLine("Directory created.");

            string fileName = "helloworld.txt";
            string filePath = Path.Combine(mypath, fileName);

            //if (File.Exists(mypath))
            //{
            //    Console.WriteLine("File already exist's.");
            //}

            //File.WriteAllText(filePath, "hello bro\n");
            //File.WriteAllText(filePath, "kaise ho, sab badiya ?");  // overwrites the file 

            //File.AppendAllText(filePath, "kaise hai, sab badiya ?\n");
            //File.AppendAllText(filePath, "chlo bye bye.");

            //string myreader = File.ReadAllText(filePath);
            //Console.WriteLine(myreader);

            //string[] line = File.ReadAllLines(myreader);
            //line.Display();            

            //File.Delete(filePath);  
            //Console.WriteLine($"File deleted: {filePath}");

            //string[] emp = {
            //                    "Rahul - IT - 45000",
            //                    "Amit - IT - 75000",
            //                    "Priya - HR - 55000"
            //                };

            //MyStreamWriter(filePath, emp);

            //MyStreamReader(filePath);


            // storing objects in file and also serializing them.

            //Employee e1 = new(){
            //        Id = 1,
            //        Name = "Harsh",
            //        DepartmentId = 2,
            //        Department = "IT",
            //        Salary = 230
            //};
            //Employee e2 = new(){
            //        Id = 1,
            //        Name = "Harsh",
            //        DepartmentId = 2,
            //        Department = "IT",
            //        Salary = 230
            //};
            //Employee e3 = new(){
            //        Id = 1,
            //        Name = "Harsh",
            //        DepartmentId = 2,
            //        Department = "IT",
            //        Salary = 230
            //};

            ////save
            //string jsonWriter = JsonSerializer.Serialize(e1);
            //File.WriteAllText(Path.Combine(mypath,"employee.json"), jsonWriter);

            //// Load
            //string jsonReader = File.ReadAllText(Path.Combine(mypath, "employee.json"));
            //Employee employee = JsonSerializer.Deserialize<Employee>(jsonReader);
            //Console.WriteLine(employee);

            string path = Path.Combine(mypath, "employee.json");

            WriteAllSerlizedObjectsToFile(path, employees);
            //ReadAllSerlizedObjectsFromFile(path);


            WriteSerlizedObjectsToFile(path, new Employee{Id=21,Name="chatur",Department="mech",DepartmentId=23,Salary=34000 });
            ReadAllSerlizedObjectsFromFile(path);

        }
    }
}