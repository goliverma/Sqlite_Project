using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project.Model.Repository.Interface;

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
    }
}
