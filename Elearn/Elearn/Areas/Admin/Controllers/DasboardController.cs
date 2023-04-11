using Microsoft.AspNetCore.Mvc;

namespace Elearn.Areas.Admin.Controllers
{
    public class DasboardController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
