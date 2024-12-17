using KansasMedicaid.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KansasMedicaid.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("UnderConstruction")]
        public IActionResult UnderConstruction()
        {
            return View();
        }

        [Route("UnderConstructionTop")]
        public IActionResult UnderConstructionTop()
        {
            return View();
        }
        [Route("Top")]
        public IActionResult Top()
        {
            return View();
        }

        [Route("IndexHMenu")]
        public IActionResult IndexHMenu()
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
