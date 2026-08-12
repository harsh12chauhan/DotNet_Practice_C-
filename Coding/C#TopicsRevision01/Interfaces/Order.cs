namespace Interfaces
{
    internal class Order
    {
        public static int OrderId { get; private set; }
        public double Amount { get; private set; }

        public Order(double amount)
        {

            OrderId = OrderId + 1;
            Amount = amount;
        }

        public void ProcessPayment(IPaymentMethod paymentMethod)
        {

            paymentMethod.Pay(Amount);

        }

    }
}
