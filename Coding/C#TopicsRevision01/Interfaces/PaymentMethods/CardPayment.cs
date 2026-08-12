namespace Interfaces.PaymentMethods
{
    internal class CardPayment : IPaymentMethod, IRefundable
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paid: {amount}  via Card");
        }

        public void Refund(double amount)
        {
            Console.WriteLine($"Refund: {amount}  via Card");

        }

    }
}
