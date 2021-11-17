using FurnitureFactoryWeb.Models;
using FurnitureFactoryWeb.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureFactoryWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly FurnitureFactoryContext _db;
        public HomeController(FurnitureFactoryContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var customers = _db.Customers.Take(15).ToList();
            var employees = _db.Employees.Take(15).ToList();
            List<FilterOrderViewModel> orders = _db.Orders
                .OrderByDescending(d => d.Date)
                .Select(t => new FilterOrderViewModel { Id = t.Id, CustomerId = t.Customer.Id, EmployeeId = t.Employee.Id, Discount = t.Discount, Evaluation = t.Evaluation, Date = t.Date })
                .Take(15)
                .ToList();

            HomeViewModel homeViewModel = new HomeViewModel { Customers = customers, Employees = employees};
            return View(homeViewModel);
        }
    }
}
