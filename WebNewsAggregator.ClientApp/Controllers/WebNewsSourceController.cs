using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebNewsAggregator.ClientApp.Models;

namespace WebNewsAggregator.ClientApp.Controllers
{
    public class WebNewsSourceController : Controller
    {
        private readonly ILogger<WebNewsSourceController> _logger;

        public WebNewsSourceController(ILogger<WebNewsSourceController> logger)
        {
            _logger = logger;
        }


        public IActionResult AddSource()
        {
            return View();
        }
        public IActionResult Create()
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