using HelloCoreMVC.Models;

using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;


namespace HelloCoreMVC.Repository
{
    public interface IEmployeeRepository
    {
        DbSet<Employee> GetEmployees();
        Task<Employee> GetEmployee(int employeeId);
    }
}
