using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProductoEjmplo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

 

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page. >c";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page. c:";

            return View();
        }


        public IActionResult Error()
        {
            return View();
        }
    }
}
