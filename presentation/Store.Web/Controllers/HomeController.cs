using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Store.Web.Models;

namespace Store.Web.Controllers
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
            _logger.LogInformation("Index Enter");
            
            try
            {
                return View();
            }
            finally
            {
                _logger.LogInformation("Index Exit");
            }
        }

        public IActionResult Privacy()
        {
            _logger.LogInformation("Privacy Enter");

            try
            {
                return View();
            }
            finally
            {
                _logger.LogInformation("Privacy Exit");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
