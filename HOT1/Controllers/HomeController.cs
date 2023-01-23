using HOT1.Models;
using Microsoft.AspNetCore.Mvc;

namespace HOT1.Controllers {
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.DistanceConverted = 0;
            ViewBag.DistanceInInches = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(DistanceConverterModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.DistanceConverted = model.InchesToCM();
                ViewBag.DistanceInInches = model.DistanceInInches;
            } 
            else
            {
                ViewBag.DistanceConverted = 0;
                ViewBag.DistanceInInches = 0;
            }
            return View(model);
        }
    }
}