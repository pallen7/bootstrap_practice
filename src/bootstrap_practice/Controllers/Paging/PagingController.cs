using bootstrap_practice.ViewModels;
using Microsoft.AspNet.Mvc;

namespace bootstrap_practice.Controllers.Paging
{
    public class PagingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(PagingViewModel view_model)
        {
            return View(view_model);
        }
    }
}
