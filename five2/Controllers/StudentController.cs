using Microsoft.AspNetCore.Mvc;
using lab5Q2.Models;

namespace lab5Q2.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ShowInfo(StudentModel student)
        {
            if (ModelState.IsValid)
            {
                return View("Result", student);
            }
            return View("Index");
        }

        public IActionResult Result(StudentModel student)
        {
            return View(student);
        }
    }
}
