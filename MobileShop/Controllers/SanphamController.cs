﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Controllers
{
    public class SanphamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}