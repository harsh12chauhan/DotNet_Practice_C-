namespace Delegates
{
    internal static class ProcessFile
    {
        // Delegates mini project
        public delegate void ProcessFilehandler(string File);
        public static void LogToConsole(string File)
        {
            Console.WriteLine($"{File} is logged to Console");
        }

        public static void SaveToDatabase(string File)
        {

            Console.WriteLine($"{File} Data saved to database");

        }

        public static void SendEmail(string File)
        {

            Console.WriteLine($"{File} Email Send");

        }
        
        public static void SendSms(string File)
        {

            Console.WriteLine($"{File} Send via Sms");

        }

        public static void Process(string File, ProcessFilehandler processFileHandler) {

            processFileHandler(File);

        }
        public static void Process02(string File, Action<string> processFileHandler) {

            processFileHandler(File);

        }

    }
}
