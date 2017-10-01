
using System;
using System.Collections.Generic;
using System.Linq;
using lab12_brian.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace lab12_brian.Controllers
{
    public class StudentController : Controller
    {
        public ViewResult Index()
        {

            ViewBag.Welcome = "Here is a list of students";

            List<Student> students = new List<Student>();

            students.Add(new Student { Name = "Brian", Program = "ASP.NET", StartYear = 2017 });
            students.Add(new Student { Name = "Jon", Program = "Paython", StartYear = 2016 });
            students.Add(new Student { Name = "Mike", Program = "JavaScript", StartYear = 2017 });
            students.Add(new Student { Name = "Jane", Program = "Java Script", StartYear = 2016 });
            students.Add(new Student { Name = "Amy", Program = "Java Script", StartYear = 2017 });

            return View(students);
        }
        [Route("Reg")]
        public string Registration(string student)
        {
            return ("Welcome to the registration page");
        }
    }
}
