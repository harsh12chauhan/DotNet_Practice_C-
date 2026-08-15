using Interfaces.PaymentMethods;

namespace Interfaces
{

    internal class Program
    {

        public static void Main(string[] args)
        {

            IPaymentMethod payment = new UPIPayment();
            payment.Pay(500);

            payment = new CardPayment();
            payment.Pay(400);

            payment = new CashPayment();
            payment.Pay(1000);

            Order order = new Order(1200);
            order.ProcessPayment(new UPIPayment());


            // IRefundable test
            CardPayment cardPayment = new CardPayment();

            cardPayment.Pay(1000);
            cardPayment.Refund(500);

            CashPayment cashPayment = new CashPayment();

            cashPayment.Pay(1000);
            // cashPayment.Refund(500);

            IRefundable refundUPIPayment = new UPIPayment();
            refundUPIPayment.Refund(300);

            //Bonus
            payment = new WalletPayment();
            payment.Pay(1500);

        }
    }

}