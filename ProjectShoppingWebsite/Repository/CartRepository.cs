using ProjectShoppingWebsite.DataAccessLayer;
using ProjectShoppingWebsite.Models;

namespace ProjectShoppingWebsite.Repository
{
    public class CartRepository:ICartRepository
    {
        public ShoppingContext shoppingContext;

        public CartRepository(ShoppingContext shoppingContext)
        {
            this.shoppingContext = shoppingContext;
        }

        public bool AddCart(Cart cart)
        {
            Cart c = new Cart();
            c.OrderId = cart.OrderId;
            c.CustomerId = cart.CustomerId;
            shoppingContext.Add(cart);
            shoppingContext.SaveChanges();
            return true;
        }
        public bool DeleteCart(int id)
        {
            Cart cart = shoppingContext.Carts.Find(id);
            shoppingContext.Carts.Remove(cart);
            shoppingContext.SaveChanges();
            return true;
        }
    
        public Cart GetCart(int id)
        {
            Cart cart = shoppingContext.Carts.Find(id);
            return cart;
        }



    }
}
