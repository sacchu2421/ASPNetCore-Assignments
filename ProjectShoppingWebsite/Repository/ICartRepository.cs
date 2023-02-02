using ProjectShoppingWebsite.Models;

namespace ProjectShoppingWebsite.Repository
{
    public interface ICartRepository
    {
        public bool AddCart(Cart cart);
        public bool DeleteCart(int id);
        public Cart GetCart(int id);

        
    }
}
