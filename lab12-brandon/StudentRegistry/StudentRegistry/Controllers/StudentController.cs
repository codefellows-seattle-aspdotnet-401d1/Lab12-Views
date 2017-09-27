using Microsoft.AspNetCore.Mvc;
using StudentRegistry.ViewModels;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentRegistry.Controllers
{
    public class StudentController : Controller
    {
        public ViewResult Register(string name, int age, int course)
        {
            Student student = new Student
            {
                Name = name,
                Age = age,
                Course = course
            };
            return View(student);
        }

        public ViewResult ViewAll()
        {
            List<Student> students = new List<Student>
            {
                new Student
                {
                    Name = "Brandon Little",
                    Age = 31,
                    Course = 401
                },
                new Student
                {
                    Name = "George Gaylor",
                    Age = 34,
                    Course = 401
                },
                new Student
                {
                    Name = "Brian McFarlane",
                    Age = 39,
                    Course = 101
                }
            };
            return View(students);
        }

        public string Error()
        {
            return "Oh noes! An 3rr04!!!!";
        }
    }
}
