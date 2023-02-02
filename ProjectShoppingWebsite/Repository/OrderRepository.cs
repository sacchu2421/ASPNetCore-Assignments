using ProjectShoppingWebsite.DataAccessLayer;
using ProjectShoppingWebsite.Models;

namespace ProjectShoppingWebsite.Repository
{
    public class OrderRepository:IOrderRepository
    {
        public readonly ShoppingContext shoppingContext;

        public OrderRepository(ShoppingContext shoppingContext)
        {
            shoppingContext = shoppingContext;
        }
        public bool DeleteOrder(int id)
        {
            Order order = shoppingContext.Orders.Find(id);
            shoppingContext.Orders.Remove(order);
            shoppingContext.SaveChanges();
            return true;
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return shoppingContext.Orders;

        }

        public Order GetOrderById(int id)
        {
            Order order = shoppingContext.Orders.Find(id);
            return order;
        }

     

        public bool UpdateOrder(int id, Order order)
        {
            Order order1 = shoppingContext.Orders.Find(id);
            order1.Quantity = order.Quantity;
            order1.Discount = order.Discount;
            order1.ProductId = order.ProductId;
            shoppingContext.Orders.Update(order1);
            shoppingContext.SaveChanges();
            return true;

        }
        public bool CreateOrder(Order order)
        {
            Order order1 = new Order();
            order1.ProductId = order.ProductId;
            order1.Quantity = order.Quantity;
            order1.Discount= order.Discount;
            order1.ProductId=order.ProductId;
            shoppingContext.Add(order1);
            shoppingContext.SaveChanges();
            return true;


        }
    }
}
