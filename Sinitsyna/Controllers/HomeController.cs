using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sinitsyna.Models;
using System.Diagnostics;

namespace Sinitsyna.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // Получаем тему из cookies
            var theme = Request.Cookies["Theme"] ?? "light"; 
            ViewBag.Theme = theme;

            return View(await _context.Products.ToListAsync());
        }

        [HttpPost]
        public IActionResult ToggleTheme()
        {
            var currentTheme = Request.Cookies["Theme"] ?? "light";
            var newTheme = currentTheme == "dark" ? "light" : "dark";
            Response.Cookies.Append("Theme", newTheme);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Catalog()
        {
            var theme = Request.Cookies["Theme"] ?? "light"; 
            ViewBag.Theme = theme;

            var products = await _context.Products.Include(p => p.ProductType)
                                                  .Include(p => p.ProductMaterial)
                                                  .Include(p => p.ProductImages)
                                                  .ToListAsync();

            var materials = await _context.ProductMaterials.ToListAsync();
            var types = await _context.ProductTypes.ToListAsync();

            var model = (products.AsEnumerable(), materials.AsEnumerable(), types.AsEnumerable());

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}