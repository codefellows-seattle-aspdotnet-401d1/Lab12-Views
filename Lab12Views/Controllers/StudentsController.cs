using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab12Views.ViewModels;

namespace Lab12Views.Controllers
{
    public class StudentsController : Controller
    {
        StudentFileManager fileManipulator = new StudentFileManager();
        static string fileName = "student-file.txt";
        string path = Path.Combine(Environment.CurrentDirectory, @"StudentData\", fileName);

        [Route("students/add")]
        public String AddStudent(string name, int age)
        {
            return fileManipulator.Post(name, age);
        }

        public ViewResult ViewStudents()
        {
 
            return View(fileManipulator.ViewStudents());
        }

        public ViewResult SelectStudent(string name)
        {
            List <Student> sList = fileManipulator.ViewStudents();

            foreach (var s in sList)
            {
                if (s.Name == name)
                {
                    Student theStudent = s;
                    ViewData["theStudent"] = theStudent;
                }
            }

            return View();
        }
    }
}
