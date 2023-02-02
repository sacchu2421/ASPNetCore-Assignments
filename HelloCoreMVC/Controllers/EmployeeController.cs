﻿using Microsoft.AspNetCore.Mvc;
using HelloCoreMVC.DataAccessLayer;
using HelloCoreMVC.Repository;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HelloCoreMVC.Controllers
{
    public class EmployeeController : Controller
    {
        IEmployeeRepository _repository;

        public EmployeeController(EmployeeContext context)
        {
            _repository = new EmployeeRepository(context);
        }
        public async Task<IActionResult> GetEmployees()
        {
            return View(await _repository.GetEmployees().ToListAsync());
        }
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            var employee = await _repository.GetEmployee(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }
    }
}
