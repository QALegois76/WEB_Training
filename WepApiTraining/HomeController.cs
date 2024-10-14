using Microsoft.AspNetCore.Mvc;

namespace WepApiTraining
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
