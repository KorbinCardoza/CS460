using CS460_HW1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CS460_HW1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string Circumference, string Front, string Rear,string RPM,string Speed)
        {
            string[] frontGears = Front.Split(',');
            string[] rearGears = Rear.Split(',');
            List<double> speeds = new List<double>();

            if (Speed == "MPH")
            {
                for (int i = 0; i < frontGears.Length; ++i)
                {
                    for (int j = 0; j < rearGears.Length; ++j)
                    {
                        speeds.Add( (Convert.ToDouble(RPM) *
                                         (Convert.ToDouble(frontGears[i]) / Convert.ToDouble(rearGears[j])) *
                                         Convert.ToDouble(Circumference) * 60 /
                                         1000000) / 1.609);
                    }
                }
            }

            if (Speed == "KPH")
            {

                for (int i = 0; i < frontGears.Length; ++i)
                {
                    for (int j = 0; j < rearGears.Length; ++j)
                    {
                        speeds.Add(Convert.ToDouble(RPM) *
                                   (Convert.ToDouble(frontGears[i]) / Convert.ToDouble(rearGears[j])) *
                                   Convert.ToDouble(Circumference) * 60 /
                                   1000000);
                    }
                }
            }
            ViewData["fronts"] = frontGears;
            ViewData["rears"] = rearGears;
            return View(speeds);
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
