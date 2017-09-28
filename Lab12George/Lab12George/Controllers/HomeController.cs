using Lab12George.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab12George.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            Student george = new Student {
                Name = "George",
                Age = 34,
                Course = "401 C# .NET"
            };

            ViewData["george"] = george;
            return View();
        }

        public ViewResult Trash() => View();
    }
}
