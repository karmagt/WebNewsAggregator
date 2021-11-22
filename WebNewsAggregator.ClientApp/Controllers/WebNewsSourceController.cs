using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebNewsAggregator.ClientApp.Models;
using WebNewsAggregator.Entities;
using WebNewsAggregator.Services.Interfaces;

namespace WebNewsAggregator.ClientApp.Controllers
{
    public class WebNewsSourceController : Controller
    {
        private IWebNewsSourceService MyWebNewsSourceService;
        private readonly ILogger<WebNewsSourceController> _logger;

        public WebNewsSourceController(ILogger<WebNewsSourceController> logger, IWebNewsSourceService webNewsSourceService)
        {
            MyWebNewsSourceService = webNewsSourceService;
            _logger = logger;
        }


        public IActionResult AddSource()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(WebNewsSource webNewsSource)
        {
            MyWebNewsSourceService.CreateWebNewsSource(webNewsSource);
            return RedirectToAction(nameof(AddSource));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}