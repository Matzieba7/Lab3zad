using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Zadanie.Models;

namespace Zadanie.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Created()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Created(HomeModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.ilosc_powtorzen >= 1 && model.ilosc_powtorzen <= 5)
                {
                    model.Belongs = "należy";
                    return View("Created", model);
                }
                else
                {
                    model.Belongs = "nie należy";
                    return View("Created", model);
                }
            }
            else
            {
                return View(model);
            }
        }

    }
}
