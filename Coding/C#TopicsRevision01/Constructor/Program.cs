using System;

namespace Constructor
{

    internal class Program
    {
        public static void Main(string[] args) { 
        
            BankAccount account = new BankAccount();

            BankAccount account1 = new BankAccount(1, "yash", 60000);

            Console.WriteLine(account);
            Console.WriteLine(account1);

            account.Withdraw(10000);
            account.Deposit(1000);

            Console.WriteLine(account);
            Console.WriteLine(account1);

            account.Withdraw(50000);

            Console.WriteLine(account);
            Console.WriteLine(account1);

            account.Withdraw(70000);

            Console.WriteLine(account);
            Console.WriteLine(account1);

            account1.Withdraw(10000);

            Console.WriteLine(account);
            Console.WriteLine(account1);

            account1.Deposit(1000);

            Console.WriteLine(account);
            Console.WriteLine(account1);

            account1.Withdraw(50000);

            Console.WriteLine(account);
            Console.WriteLine(account1);

            account1.Withdraw(70000);

            Console.WriteLine(account);
            Console.WriteLine(account1);



        }
    }

}
