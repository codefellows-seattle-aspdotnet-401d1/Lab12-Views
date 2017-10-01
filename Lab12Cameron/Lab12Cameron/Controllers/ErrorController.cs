using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab12Cameron.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error")]
        public ViewResult Index()
        {
            string errmsg = "You took a wrong turn somewhere homie!";
            ViewData["err"] = errmsg;
            return View();

        }

    }
}
