using lab12ViewsGregory.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace lab12ViewsGregory.Controllers
{
    public class StudentsController : Controller
    {
        public ViewResult Register(string name, int? grade)
        {
            if(!String.IsNullOrEmpty(name))
            {
                string filePath = "RegisteredStudents.txt";
                using (StreamWriter sw = System.IO.File.AppendText(filePath))
                {
                    sw.Write(Environment.NewLine);
                    sw.WriteLine(name, grade);
                }
            }
            return View();
        }

        public ViewResult Display()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { FirstName = "Darcy", LastName = "Dukes", Grade = 11, SkillSet = "Mommy" });
            students.Add(new Student { FirstName = "Gregory", LastName = "Dukes", Grade = 12, SkillSet = "ASP.NET core" });
            students.Add(new Student { FirstName = "Becki", LastName = "Farris", Grade = 12, SkillSet = "Python" });
            students.Add(new Student { FirstName = "Jimbo", LastName = "BillyBob", Grade = 9, SkillSet = "Farmin'" });

            return View(students);
        }
    }
}
