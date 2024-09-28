using Microsoft.AspNetCore.Mvc;

namespace Sinitsyna.Controllers
{
    public class SomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
