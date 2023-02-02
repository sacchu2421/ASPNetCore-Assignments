using ProjectShoppingWebsite.Models;

namespace ProjectShoppingWebsite.Repository
{
    public interface IOrderRepository
    {
        public IEnumerable<Order> GetAllOrders();
        public Order GetOrderById(int id);
        public bool UpdateOrder(int id,Order order);
        public bool DeleteOrder(int id);
        public bool CreateOrder(Order order);
    }
}
