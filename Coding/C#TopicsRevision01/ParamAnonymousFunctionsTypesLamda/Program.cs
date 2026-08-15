namespace ParamAnonymousFunctionsTypesLamda
{
    internal class Program
    {
        public static int SumOfNNubmer(params int[] num)
        {

            int sum = 0;
            foreach (int n in num)
            {
                sum += n;
            }

            return sum;
        }

        public static void Main(string[] args)
        {

            // Params
            int sum = SumOfNNubmer(10, 20, 30, 40, 50, 60);
            Console.WriteLine(sum);

            // Anonymous functions
            Func<int, int, int> product = delegate (int a, int b)
            {
                return a * b;
            };

            Console.WriteLine(product(10, 20));

            // Anonymous Types
            var employee = new
            {
                Id = 1,
                Name = "harsh",
                Salary = 100000
            };

            Console.WriteLine(employee);
            Console.WriteLine(employee.Name);


            // Lambda
            Action<string> PrintName = name => Console.WriteLine($"Hello {name}");
            Func<int, int> Square = x => x * x;
            Predicate<int> IsEven = num => num % 2 == 0;


            PrintName("harsh");
            Console.WriteLine(Square(3));
            Console.WriteLine(IsEven(7));
        }
    }
}