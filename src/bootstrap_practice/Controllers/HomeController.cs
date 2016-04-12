using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace bootstrap_practice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Show(ViewModel view_model)
        {
            return View(view_model);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
