using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.StudentName = "Yahya";
            ViewBag.StudentLastName = "Sinvar";
            ViewBag.Age = 50;
            ViewBag.Description = "Siyonizme karşı ülkeisni savunan ülkesinin milli bir kahramanı";


            List<Teacher> teachers = new List<Teacher>() {
                new Teacher{ Name = "Ahmet", LastName = "Yasin" , Age = 70, Occupation = "Öğretmen" },
                new Teacher{ Name = "Abdulaziz", LastName = "Rantisi" , Age = 50, Occupation = "Doktor" },
                new Teacher{ Name = "Yahya", LastName = "Ayyaş" , Age = 40, Occupation = "Mühendis" },
            };
            ViewBag.allPhlistinLeaders = teachers;
            ViewBag.data = true;
            return View();
        }

        public IActionResult Detail(int id)
        {
            ViewData["names"] = "Yahya ayyaş,Halid Meşal,Abdullah galip bergusi,Yahya sinvar";
            TempData["test"] = "test data";
            return RedirectToAction("ExtraDetail");
        }

        public IActionResult ExtraDetail(int id)
        {
            var nevarIcinde = TempData["test"];

            List<Teacher> teachers = new List<Teacher>() {
                new Teacher{ Name = "Ahmet", LastName = "Yasin" , Age = 70, Occupation = "Öğretmen" },
                new Teacher{ Name = "Abdulaziz", LastName = "Rantisi" , Age = 50, Occupation = "Doktor" },
                new Teacher{ Name = "Yahya", LastName = "Ayyaş" , Age = 40, Occupation = "Mühendis" },
            };

            return View(teachers);
        }

    }

}
/*
 Controller dan View'e veri taşıma yöntemleri 
 ViewBag
 ViewData
 TemoData

 Model yöntemi ile veri taşıma 
 */