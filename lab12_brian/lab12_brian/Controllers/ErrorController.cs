
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace lab12_brian.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Wat")]
        public ViewResult Index()
        {
            return View();
        }
    }
}
