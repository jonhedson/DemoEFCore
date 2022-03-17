using DemoEFCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;

namespace DemoEFCore.Controllers
{
    public class HomeController : Controller
    {
        private CompanyContext context;
        public HomeController(CompanyContext cc)
        {
            context = cc;
        }

        public string Index()
        {
            var dept = new Department()
            {
                Name = "Designing"
            };

            context.Entry(dept).State = EntityState.Added;
            context.SaveChanges();

            return "Record Inserted";
        }

        public string Info()
        {
            var info = new Information()
            {
                Name = "Infnet",
                License = "XXXXX",
                Revenue = 1000,
                Established = Convert.ToDateTime("2020/06/24")
            };

            context.Information.Add(info);

            context.SaveChanges();

            return "Record Inserted";
        }

        public string Cliente()
        {
            return "Record Inserted";
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
