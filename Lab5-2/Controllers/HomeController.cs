using Lab5_2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Lab5_2.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public string About()
        {
            return "Info about ASP.NET Core";
        }

        public string Hello(string name, int? age)
        {
            if (age==null)
            {
                return $"Hello {name}, you have no age";
            }
            return $"Hello {name}, your age is {age}";
        }

        public string Power(int? num)
        {
            if (num == 0)
            {
                return $"Don't be silly! You can't do that here!";
            }
            else
            {
                return $"{num} to the power of 2 is: {num*num}";
            }
        }

        public IActionResult PowerForm()
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
