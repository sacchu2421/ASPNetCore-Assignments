using EmployeesDepartmentProjectApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeesDepartmentProjectApi.Controllers
{
    public class EmployeeController : Controller
    {
        IEmployeeRepository repo = new EmployeeRepository();
        // GET: Employee
        public ActionResult GetEmployeesDepartmentAndProject()
        {
           
            return View(repo.GetEmployeesWithProjectAndDepartment());
        }
    }
}