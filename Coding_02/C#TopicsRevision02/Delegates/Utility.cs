namespace Delegates
{
    public static class Utility
    {
        public delegate int Operation(int a, int b);
        public  static int Add(int a, int b) => a + b;
        public static int Sub(int a, int b) => a - b;
        public static int Multiply(int a, int b) => a * b;
        public static void Calculate01(int a, int b, Operation operation)
        {
            int result = operation(a, b);
            Console.WriteLine($"result: {result}");
        }

        public static void Calculate02(int a, int b, Func<int, int, int> operation)
        {
            int result = operation(a, b);
            Console.WriteLine($"Result: {result}");
        }


        // Multicasting Delegates
        public static void Email() {
            Console.WriteLine("Email send");
        }
        public static void Sms() {
            Console.WriteLine("Sms send");
        }
        public static void Whatsapp() {
            Console.WriteLine("Whatsapp message send");
        }

        public delegate void Notify();      

    }
}
