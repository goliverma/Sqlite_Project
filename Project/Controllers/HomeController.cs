using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project.Model.Repository.Interface;
using Project.ViewModel;
using Project.Model.Data;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBAL context;

        public HomeController(IBAL context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var data = await context.GetAllEmployee();
            return View(data);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ViewEmployee employee)
        {
            var Employee = new Employee{
                Name = employee.Name,
                Email = employee.Email,
                Address = employee.Address
            };
            await context.Insert(Employee);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var data = await context.GetById(id);
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> Update(ViewEmployee changeemployee)
        {
            var data = new Employee{
                Id = changeemployee.Id,
                Name = changeemployee.Name,
                Email = changeemployee.Email,
                Address = changeemployee.Address
            };
            await context.UpdateEmployee(data);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Employee(int id)
        {
            var data = await context.GetById(id);
            return View(data);
        }
        public async Task<IActionResult> Delete(int id)
        {
            await context.DeleteEmployee(id);
            return RedirectToAction("Index");
        }
    }
}
