using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class Employee1Controller : Controller
    {
        public IActionResult Index()
        {
            IList<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { ID = 123, FirstName = "Sowjanya", LastName = "Gollapathi" });
            employees.Add(new Employee() { ID = 124, FirstName = "ABC", LastName = "XYZ" });
            ViewData["employees"] = employees;
            ViewBag.TotalEmployees = employees.Count();

            return View();
        }
    }
}
