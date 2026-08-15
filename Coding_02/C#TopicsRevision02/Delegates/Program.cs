using System;

namespace Delegates {

    internal class Program {        
        public static void Main(string[] args) {


            Utility.Calculate02(1, 2, Utility.Add);
            Utility.Calculate02(3, 2, Utility.Sub);
            Utility.Calculate02(3, 4, Utility.Multiply);

            // Modern .Net -----------            
            Utility.Calculate02(3, 2, (a, b) => a + b);
            Utility.Calculate02(3, 5, (a, b) => a - b);
            Utility.Calculate02(3, 4, (a, b) => a * b);

            //Multicasting Delegates ---------------
            Utility.Notify notify = Utility.Email;
            notify += Utility.Sms;
            notify += Utility.Sms;
            notify += Utility.Whatsapp;
            notify();

            notify -= Utility.Sms;
            notify();

            //Mini project -------------         
            ProcessFile.Process("report.txt", ProcessFile.SaveToDatabase);
            ProcessFile.Process("report.txt", ProcessFile.LogToConsole);
            ProcessFile.Process("report.txt", ProcessFile.SendEmail);

            ProcessFile.Process02("readme.md",ProcessFile.SendSms);

            // 1 more mini challange
            ProcessFile.ProcessFilehandler handler = ProcessFile.SaveToDatabase;
            handler += ProcessFile.LogToConsole;
            handler += ProcessFile.SendEmail;
            handler += ProcessFile.SendSms;

            handler("UserRecords.txt");

        }
    }

}