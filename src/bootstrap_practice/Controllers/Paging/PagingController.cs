using bootstrap_practice.Model;
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
        public IActionResult Index(PagingRequest paging_request)
        {
            return View("Results", paging_request);
        }

        public IActionResult Results(PagingRequest paging_request)
        {
            var paging_item_handler = new GetPagingItems();

            var view_model = paging_item_handler.build_view_model(paging_request.items_per_page, paging_request.page_number);

            return View(view_model);
        }
    }
}
