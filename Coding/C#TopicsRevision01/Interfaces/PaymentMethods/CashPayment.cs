namespace Interfaces.PaymentMethods
{
    internal class CashPayment : IPaymentMethod
    {
        public void Pay(double amount)
        {

            Console.WriteLine($"Paid: {amount}  via Cash");

        }

    }
}
