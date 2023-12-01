using Microsoft.AspNetCore.Mvc;
using Proper.Areas.Admin.ViewModels.Banner;

namespace Proper.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BannerController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(BannerCreateVM bannerCreateVM)
        {
            if (!ModelState.IsValid)
            {

            }
            return RedirectToAction("Index", "Card");
        }
    }
}
