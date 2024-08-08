using Microsoft.AspNetCore.Mvc;

namespace TI43_Teste.Controllers
{
    public class SlideFilmesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
