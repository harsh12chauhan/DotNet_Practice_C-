namespace Interfaces.PaymentMethods
{
    internal class UPIPayment : IPaymentMethod, IRefundable
    {
        public void Pay(double amount)
        {

            Console.WriteLine($"Paid: {amount} via UPI");

        }

        public void Refund(double amount)
        {

            Console.WriteLine($"Refund: {amount} via UPI");

        }

    }
}
