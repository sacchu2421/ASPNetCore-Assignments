using HelloMVCWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace HelloMVCWebApp.DataAccessLayer
{
    public class EmployeeContext:DbContext
    {

        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
