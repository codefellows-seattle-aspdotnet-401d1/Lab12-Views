using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab12ViewsGregory.Controllers
{
    [Route("Error")]

    public class ErrorController : Controller
    {
        [Route("Error")]

        public string Index()
        {
            return "Uh oh, something went wrong.";
        }
    }
}
