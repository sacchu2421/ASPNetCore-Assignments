using HelloMVCWebApp.DataAccessLayer;
using HelloMVCWebApp.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace HelloMVCWebApp.Repository
{
    public class EmployeeRepository:IEmployeeRepository
    {

        private readonly EmployeeContext _context;
        public EmployeeRepository(EmployeeContext context)
        {
            _context = context;
        }
        public DbSet<Employee> GetEmployees()
        {
            return _context.Employees;
        }
        public async Task<Employee> GetEmployee(int employeeId)
        {
            return await _context.Employees.FindAsync(employeeId);
        }
    }
}
