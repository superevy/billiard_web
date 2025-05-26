using System.Diagnostics;
using billiard_web.Models;
using Microsoft.AspNetCore.Mvc;

namespace billiard_web.Controllers
{
    public class BookingController : Controller
    {
        public ActionResult Index()
        {
            return View("Booking", new BookingModel()); 
        }


        [HttpPost]
        public ActionResult Order(BookingModel model)
        {
            if (ModelState.IsValid)
            {
                TempData["Order"] = model;
                return RedirectToAction("ViewOrder");
            }
            return View("Index", model);
        }

        public ActionResult ViewOrder()
        {
            var model = TempData["Order"] as BookingModel;
            return View(model);
        }
    }
}
