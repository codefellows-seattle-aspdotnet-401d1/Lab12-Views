using Lab12Views.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab12Views.Controllers
{
    public class StudentController : Controller
    {
        string filePath = @"students.txt";

        public ViewResult Student()
        {

            List<Student> students = new List<Student>
            {
                new Student { Name = "Jim Bob", Age = 31, Id = 123456, Major = "Engineering" },
                new Student { Name = "Billy Bob", Age = 22, Id = 654321, Major = "Biology" },
                new Student { Name = "Duane Rush", Age = 27, Id = 8675309, Major = "Code Ninja" }
            };

            //not working as intended
            using (System.IO.StreamWriter sw = System.IO.File.AppendText(filePath))
            {
                foreach (var s in students)
                {
                    sw.Write(s.Name);
                    sw.Write(" ");
                    sw.Write(s.Age);
                    sw.Write(" ");
                    sw.Write(s.Id);
                    sw.Write(" ");
                    sw.Write(s.Major);
                    sw.WriteLine("");

                }
            }
            return View(students);


        }
    }
}
