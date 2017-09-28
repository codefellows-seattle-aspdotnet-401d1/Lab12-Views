using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab12Views.Controllers
{
    [Route("Error")]
    public class ErrorController
    {
        [Route("Support")]
        public string Index()
        {
            return "Uh oh you found the error page contact someone who cares";
        }
    }
}
