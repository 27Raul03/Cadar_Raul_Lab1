using Microsoft.AspNetCore.Mvc;
using Cadar_Raul_Lab1.Models;

namespace Cadar_Raul_Lab1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Info()
        {
            ViewBag.Message = "Mesaj din Controller";
            ViewData["Time"] = DateTime.Now;

            var student = new Student { Name = "Ana", Age = 21 };
            return View(student);

        }
    }
}
