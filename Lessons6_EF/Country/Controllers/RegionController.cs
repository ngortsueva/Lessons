using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CountryWeb.Controllers
{
    public class RegionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}