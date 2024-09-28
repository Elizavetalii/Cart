using Microsoft.AspNetCore.Mvc;
using Sinitsyna.Models;
using System.Diagnostics;

namespace Sinitsyna.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext _context;


        private readonly ILogger<HomeController> _logger;
        //public HomeController(AppDbContext context)
        //{
        //    _context = context;
        //}
        public async Task<IActionResult> Index()
        {
            var theme = HttpContext.Items["Theme"]?.ToString();
            ViewBag.Theme = theme;
            //return View(await _context.Users.ToListAsync());
            return View();
        }

        [HttpPost]
        public IActionResult ToggleTheme()
        {
            var currentTheme = HttpContext.Items["Theme"].ToString();
            var newTheme = currentTheme == "dark" ? "light" : "dark";

            // Устанавливаем новую тему в cookie
            Response.Cookies.Append("Theme", newTheme);

            return RedirectToAction("Index"); // Возвращаемся на главную страницу
        }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Catalog()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
