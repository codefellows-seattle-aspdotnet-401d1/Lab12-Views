﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab12George.Controllers
{
    public class ErrorController
    {
        // attribute routing replaces the routes
        [Route("Error")]
        public ViewResult Index => View();
    }
}
