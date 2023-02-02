using EmployeesDepartmentProjectApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesDepartmentProjectApi.Repository
{
    internal interface IEmployeeRepository
    {
        DbSet<Employee> GetEmployeesWithProjectAndDepartment();
    }
}
