using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(string name, int age)
        {

            TempData["name"] = name;
            TempData["age"] = age;

            return RedirectToAction("Success");
        }


        public IActionResult Success(string name, int age)
        {
            ViewBag.Name = TempData["name"];
            ViewBag.Age = TempData["age"];

            return View();
        }
    }
}
