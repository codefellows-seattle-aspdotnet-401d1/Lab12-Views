using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab12George.Controllers
{
    public class StudentsController : Controller
    {
        public ViewResult Index() => View();
        [Route("AddStudent")]
        // This is called model binding
        public string Student(string name, int age)
        {
            if (name == "" || age == 0)
            {
                return "No movie input";
            }
            else
            {
                return $"Student name is {name} and age is {age}.";
            }
        }
    }
}
