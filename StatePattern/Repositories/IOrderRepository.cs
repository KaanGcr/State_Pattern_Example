using StatePattern.Entities;

namespace StatePattern.Repositories
{
    public interface IOrderRepository
    {
        List<Order> GetAll();
        Order GetById(int Id);
    }
}
