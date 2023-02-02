using ProjectShoppingWebsite.DataAccessLayer;
using ProjectShoppingWebsite.Models;

namespace ProjectShoppingWebsite.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public readonly ShoppingContext shopping;

        public CustomerRepository(ShoppingContext shoppingContext)
        {
            this.shopping = shoppingContext;
        }
        public IEnumerable<Customer> GetAllCustomer()
        {
            var query = (from customer in shopping.Customers
                         select customer).ToList();
            return query;

        }
        public Customer GetCustomerById(int id)
        {
            Customer customer = shopping.Customers.Find(id);
            return customer;
        }

        public bool AddCustomer(Customer customer)
        {
            Customer customer1 = new Customer();
            customer1.UserName = customer.UserName;
            customer1.Address = customer.Address;
            customer1.Phone = customer.Phone;
            customer1.Password = customer.Password;
            shopping.Customers.Add(customer);
            shopping.SaveChanges();
            return true;
        }
        public bool DeleteCustomer(int id)
        {
            Customer customer = shopping.Customers.Find(id);
            shopping.Customers.Remove(customer);
            shopping.SaveChanges();
            return true;
        }
        public bool UpdateCustomer(int id, Customer customer)
        {
            Customer custom = shopping.Customers.Find(id);
            custom.Phone = customer.Phone;
            custom.UserName = customer.UserName;
            custom.Address = customer.Address;
            custom.Password = customer.Password;
            shopping.Update(custom);
            return true;
        }
        public Customer GetCustomerByUserPass(string username, string password)
        {
            var customer = from cust in shopping.Customers
                           where cust.UserName == username && cust.Password == password
                           select cust;
            return (Customer)customer;
                           
        }
        public bool IsValidUser(Customer customer)
        {
            Customer user = new Customer();

            user.UserName = customer.UserName;
            user.Password = customer.Password;

            var users = shopping.Customers.FirstOrDefault(y => y.UserName == user.UserName && y.Password == user.Password);

            if (users == null)
            {
                return false;
            }
            else
            {
                return true;
            }


        }
    }
}
