using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab12ViewsGregory.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }


        public ViewResult Faculty()
        {
            return View();
        }
    }
}
