using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zadanie.Models;

namespace Zadanie.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(FormModel model)
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