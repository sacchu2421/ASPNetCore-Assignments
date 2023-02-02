using HelloCoreMVC.Models;
using Microsoft.EntityFrameworkCore;
namespace HelloCoreMVC.DataAccessLayer
{

    public class EmployeeContext : DbContext
    {

            public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
            {

            }
            public DbSet<Employee> Employees { get; set; }
        }
    }

