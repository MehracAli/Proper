using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Proper.Context.Contexts;
using Proper.Core.Entities.Banners;
using Proper.Core.Enums;
using Proper.ViewModels.HomeVMs;

namespace Proper.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProperDbContext _context;
        private readonly IMapper _mapper;

        public HomeController(ProperDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            Banner? bannerTop = _context.Banners.FirstOrDefault(b => b.BannerPosition.Equals(BannerPosition.Top.ToString()));
            Banner? bannerBottom = _context.Banners.FirstOrDefault(b => b.BannerPosition.Equals(BannerPosition.Bottom.ToString()));

            HomeVM homeVM = new ()
            {
                BannerTopVM = _mapper.Map<BannerTopHomeVM>(bannerTop),
                BannerBottomVM = _mapper.Map<BannerBottomHomeVM>(bannerBottom)
            };

            return View(homeVM);
        }
    }
}