namespace ExceptionsTryCatchFinally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter employee salary: ");
                int salary = int.Parse(Console.ReadLine());

                if (salary < 0)
                {
                    throw new Exception("Salary cannot be negative.");
                }
                else if (salary == 10000)
                {
                    throw new MyCustomException("salary is very less.");
                }

                int bonus = 10000;

                int totalSalary = salary + bonus;

                Console.WriteLine($"Total Salary: {totalSalary}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Salary processing completed.");
            }
        }
    }
}
