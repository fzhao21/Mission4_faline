using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mission4_faline.Models;

namespace Mission4_faline.Controllers
{
    public class BlahController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult gradeCalculator()
        {
            return View();
        }

        [HttpPost]
        public IActionResult gradeCalculator(gradeCalculatorClass model)
        {
            return View();
        }
    }
}
