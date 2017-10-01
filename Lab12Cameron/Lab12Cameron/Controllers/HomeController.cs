using Lab12Cameron.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab12Cameron.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            Student rapGods = new Student()
            {
                MC = "Jay-Z",
                Hometown = "Brooklyn",
                Albums = 13

            };

            return View(rapGods);
        }
    }
}
