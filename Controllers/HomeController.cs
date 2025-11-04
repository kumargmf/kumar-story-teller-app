using Microsoft.AspNetCore.Mvc;
using StoryBookTeller.Models;
using System.Diagnostics;

namespace StoryBookTeller.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            var model = new HomeViewModel
            {
                ApplicationName = _configuration["ApplicationSettings:ApplicationName"] ?? "StoryBook Teller",
                Description = _configuration["ApplicationSettings:Description"] ?? "Create amazing stories from your images!",
                Version = _configuration["ApplicationSettings:Version"] ?? "1.0.0"
            };

            return View(model);
        }

        public IActionResult Privacy()
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