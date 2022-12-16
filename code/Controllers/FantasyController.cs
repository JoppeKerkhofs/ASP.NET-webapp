using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using code.Models;
using Contentful.Core;

namespace code.Controllers
{
    public class FantasyController : Controller
    {
        private readonly ILogger<FantasyController> _logger;

        private readonly IContentfulClient _client;

        public FantasyController(ILogger<FantasyController> logger, IContentfulClient client)
        {
            _client = client;
            _logger = logger;
        }

        public async Task<IActionResult> Fantasy()
        {
            var movies = await _client.GetEntries<Movie>();
            return View(movies);
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
