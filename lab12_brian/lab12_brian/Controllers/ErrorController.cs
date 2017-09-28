
using Microsoft.AspNetCore.Mvc;

namespace lab12_brian.Controllers
{
    [Route("Error")]
    public class ErrorController : Controller
    {
        [Route("Wat")]
        public string Index()
        {
            return "Ooops, an unexpected error has occured, try turning it off and on again";
        }
    }
}
