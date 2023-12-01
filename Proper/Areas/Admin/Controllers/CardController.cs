using Microsoft.AspNetCore.Mvc;

namespace Proper.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
