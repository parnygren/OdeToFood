using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new Restaurant {Id = 1, Name = "Pär's Pizza Place"};

            return View(model);
        }
    }
}
