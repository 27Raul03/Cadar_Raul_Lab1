using Microsoft.AspNetCore.Mvc;

namespace Cadar_Raul_Lab1.Controllers
{
    public class MyController : Controller
    {
        public string Index()
        {
            return "Welcome!";
        }
        public string Hello()
        {
            return "Hello World!";
        }
        public string More(string name, int age)
        {
            return $"Hello {name}, you are {age} years old!";
        }
    }
}
