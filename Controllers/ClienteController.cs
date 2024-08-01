using Microsoft.AspNetCore.Mvc;

namespace TI43_Teste.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
