using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegistry.Controllers
{
    public class StudentController : Controller
    {
        public ViewResult Register(string name, int age, int course)
        {
            return View();
        }

        public ViewResult ViewAll()
        {
            return View();
        }

        public string Error()
        {
            return "Oh noes! An 3rr04!!!!";
        }
    }
}
