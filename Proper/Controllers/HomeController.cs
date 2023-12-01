using Microsoft.AspNetCore.Mvc;
using Proper.Context.Contexts;
using Proper.ViewModels.HomeVMs;

namespace Proper.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProperDbContext _context;

        public HomeController(ProperDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                BannerVM = _context.Banners.Select(b => new BannerVM { 

                    ImageURL = b.ImageURL,
                    Title = b.Title,
                    Description = b.Description,
                    ButtonText = b.ButtonText,

                }).FirstOrDefault(),
            };
            return View();
        }
    }
}