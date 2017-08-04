using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WeChatBrowserDetection.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var agent = Request.Headers["User-Agent"];
            Console.WriteLine(agent.ToString());
            ViewBag.Message = agent.ToString();

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
