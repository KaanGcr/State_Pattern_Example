using StatePattern.Entities;
using StatePattern.Enums;

namespace StatePattern.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public List<Order> Orders { get; set; }

        public OrderRepository()
        {
            Orders = FillOrders();
        }

        private List<Order> FillOrders()
        {
            return new List<Order>()
            {
                new Order()
                {
                    Id = 1,
                    Amount = 100,
                    OrderStatus = OrderStatus.WaitingForPayment,
                    UserName = "Kaan"
                },
                new Order()
                {
                    Id = 2,
                    Amount = 20,
                    OrderStatus = OrderStatus.PreparingForDispatch,
                    UserName = "Alex"
                },
                new Order()
                {
                    Id = 3,
                    Amount = 10,
                    OrderStatus = OrderStatus.Delivered,
                    UserName = "Jensen"
                },
                new Order()
                {
                    Id = 4,
                    Amount = 50,
                    OrderStatus = OrderStatus.Delivered,
                    UserName = "Michelle"
                },
                new Order()
                {
                    Id = 5,
                    Amount = 70,
                    OrderStatus = OrderStatus.Cancelled,
                    UserName = "Charlotte"
                }
            };
        }

        public List<Order> GetAll()
        {
            return this.Orders;
        }

        public Order GetById(int Id)
        {
            return this.Orders
                .FirstOrDefault(x => x.Id == Id);
        }
    }
}
