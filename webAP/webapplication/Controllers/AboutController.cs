﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return View("about");
        }
    }
}
