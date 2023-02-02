using ProjectShoppingWebsite.Models;

namespace ProjectShoppingWebsite.Repository
{
    public interface ICustomerRepository
    {
        public IEnumerable<Customer> GetAllCustomer();
        public Customer GetCustomerById(int id);
        public Customer GetCustomerByUserPass(string username, string password);
        public bool DeleteCustomer(int id);
        public bool UpdateCustomer(int id,Customer customer);
        public bool AddCustomer(Customer customer);
    }
}
