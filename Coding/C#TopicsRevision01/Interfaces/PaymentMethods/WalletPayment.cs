namespace Interfaces.PaymentMethods
{
    internal class WalletPayment : IPaymentMethod
    {
        public void Pay(double amount)
        {

            Console.WriteLine($"Paid: {amount}  via Wallet");

        }
    }
}
