using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.CalcOperation;  //not using CalcOperation

namespace WebApplication2.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult Total(int value1, int value2, string calc)
        {
            ViewBag.Value = CalcOperation.CalcOperation.Total(value1, value2, calc);
            return View("Index");
        }
        
    }
}