using lab5.Models;
using Microsoft.AspNetCore.Mvc;


namespace lab5.Controllers
{
    public class SimpleInterestController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculate(SimpleInterestModel model)
        {
            if (ModelState.IsValid)
            {
                model.Interest = (model.Principal * model.Rate * model.Time) / 100;
                return View("Result", model);
            }
            return View("Index");
        }

        public IActionResult Result(SimpleInterestModel model)
        {
            return View(model);
        }
    }
}