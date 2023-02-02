using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using HelloMVCWebApp.Models;
namespace HelloMVCWebApp.Repository
{
    public interface IEmployeeRepository
    {
        DbSet<Employee> GetEmployees();
        Task<Employee> GetEmployee(int employeeId);
    }
}
