using Microsoft.AspNetCore.Mvc;
using WheatherAppLayoutView.Models;

namespace WheatherAppLayoutView.Controllers
{
    public class HomeController : Controller
    {
        public List<CityWheater> cities = new List<CityWheater>()
        {
            new CityWheater() { CityUniqueCode = "LDN", CityName = "London", DateAndTime = DateTime.Parse("2030-01-01 8:00"), Temperature = 33 },
            new CityWheater() { CityUniqueCode = "NYC", CityName = "New York", DateAndTime = DateTime.Parse("2030-01-01 3:00"), Temperature = 60 },
            new CityWheater() { CityUniqueCode = "PAR", CityName = "Paris", DateAndTime = DateTime.Parse("2030-01-01 9:00"), Temperature = 82 }

        };


        [Route("/")]
        public IActionResult Index()
        {
            ViewData["Option"] = "Details";
            return View(cities);
        }

        [Route("Country/Details")]
        public IActionResult Details([FromQuery]string code)
        {
            
            var city = cities.FirstOrDefault(c => c.CityUniqueCode == code);
            if (city == null)
            {
                return PartialView("_CityNotFound");
            }
            ViewData["Option"] = "Back to home"; 
            return View(new List<CityWheater>  { city } );
        }

        public IActionResult Error(int? id)
        {
            if (id == 404)
            {
                ViewBag.ErrorTitle = "Página no encontrada";
                ViewBag.ErrorMessage = $"La página que buscas no existe o fue movida {StatusCodes.Status404NotFound}";
            }
            else
            {
                ViewBag.ErrorTitle = "Ocurrió un error";
                ViewBag.ErrorMessage = "No se pudo procesar la solicitud.";
            }

            return View();
        }
    }
}
