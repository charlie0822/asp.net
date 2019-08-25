using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Employeelist()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{ID=0001,Name="charlie",Phone="0978383245",Email="charlie80037@gmail.com"},
                new Employee{ID=0002,Name="john",Phone="0123456789",Email="adad456@gmail.com"},
                new Employee{ID=0003,Name="abc",Phone="8754235489",Email="zxcf5587@gmail.com"},
                new Employee{ID=0004,Name="abc456",Phone="3327823479",Email="78952@gmail.com"},
                new Employee{ID=0005,Name="abcsad",Phone="7895410023",Email="asdasdcxz@gmail.com"},
            };
            return View(employees);
        }
    }
}