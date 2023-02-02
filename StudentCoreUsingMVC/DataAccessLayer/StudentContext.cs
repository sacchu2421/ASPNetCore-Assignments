using Microsoft.EntityFrameworkCore;
using StudentCoreUsingMVC.Models;
//using System.Data.Entity;
namespace StudentCoreUsingMVC.DataAccessLayer
{
    public class StudentContext:DbContext
    {

        public StudentContext(DbContextOptions<StudentContext> options): base(options)
        {

        }
        public DbSet<Student> Students { get; set; } 
    }
}
