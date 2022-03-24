using StatePattern.Enums;

namespace StatePattern.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public decimal Amount { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public string CheckStatus()
        {
            return this.OrderStatus.ToString();
        }

        public void Cancel()
        {
            if (this.OrderStatus == OrderStatus.WaitingForPayment)
            {
                this.OrderStatus = OrderStatus.Cancelled;
            }
            else
            {
                Console.WriteLine("Can not be cancelled.");
            }
        }

        public void ProcessFurther(PaymentStatus PaymentStatus)
        {
            switch (PaymentStatus)
            {
                case PaymentStatus.Success:
                    this.OrderStatus = OrderStatus.PreparingForDispatch;
                    Console.WriteLine("Payment completed.");
                    break;
                case PaymentStatus.Fail:
                    this.OrderStatus = OrderStatus.Cancelled;
                    Console.WriteLine("Payment failed. Order will be cancelled");
                    break;
                case PaymentStatus.Pending:
                    this.OrderStatus = OrderStatus.WaitingForPayment;
                    Console.WriteLine("Waiting for payment.");
                    break;
                default:
                    break;
            }
        }
    }
}
