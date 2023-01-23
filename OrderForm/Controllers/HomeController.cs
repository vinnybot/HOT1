using OrderForm.Models;
using Microsoft.AspNetCore.Mvc;

namespace OrderForm.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(OrderFormModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Total = model.CalculateTotal();
                ViewBag.Qty = model.Qty;
                ViewBag.Tax = model.CalculateTax();
                ViewBag.SubTotal = model.CalculateSubTotal();
                ViewBag.PricePerShirt = model.PricePerShirt;
                ViewBag.DiscountMessage = model.DiscountMessage;
            }
            else
            {
                ViewBag.Total = 0;
                ViewBag.Qty = 0;
                ViewBag.Tax = 0;
                ViewBag.SubTotal = 0;
                ViewBag.PricePerShirt = 0;
                ViewBag.DiscountMessage = "";
            }
            return View(model);
        }
    }
}