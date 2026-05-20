using Microsoft.AspNetCore.Mvc;

namespace WheatherAppLayoutView.Controllers
{
    public class WeatherController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
