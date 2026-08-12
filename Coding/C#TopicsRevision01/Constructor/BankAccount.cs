using System;

namespace Constructor
{
    internal class BankAccount
    {

        public int AccountNumber { get; private set; }
        public string HolderName { get; set; }
        public double Balance { get; private set; }

        public BankAccount() : this(0, "Unknown", 0.0) { }

        public BankAccount(int accountNumber, string holderName, double balance){ 
            AccountNumber = accountNumber;
            HolderName = holderName;
            Balance = balance;       
        }       

        public void Withdraw(double amount) {

            if (amount > 0 && Balance >= amount) 
            { 
                Balance -= amount; 
            }
        }

        public void Deposit(double amount)
        {
            
            if (amount > 0)
            {
                Balance += amount;
            }
        }

        public override string ToString()
        {
            return AccountNumber + " - " + HolderName + " - " + Balance;
        }

    }
}
