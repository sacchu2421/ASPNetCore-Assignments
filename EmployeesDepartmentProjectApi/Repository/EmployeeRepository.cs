using EmployeesDepartmentProjectApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmployeesDepartmentProjectApi.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
     

        DbSet<Employee> IEmployeeRepository.GetEmployeesWithProjectAndDepartment()
        {
            throw new NotImplementedException();
        }
    }
}