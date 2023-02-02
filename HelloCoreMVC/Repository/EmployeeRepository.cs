﻿using HelloCoreMVC.Models;
using System.Threading.Tasks;
using HelloCoreMVC.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
namespace HelloCoreMVC.Repository
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
