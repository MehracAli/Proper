using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Proper.Areas.Admin.ViewModels.Banners;
using Proper.Areas.Admin.ViewModels.MainVMs;
using Proper.Context.Contexts;
using Proper.Core.Entities.Banners;
using Proper.Core.Enums;

namespace Proper.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CardController : Controller
    {
        private readonly ProperDbContext _context;
        private readonly IMapper _mapper;

        public CardController(ProperDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public  IActionResult Index()
        {
            Banner? bannerTop =  _context.Banners.FirstOrDefault(b => b.BannerPosition.Equals(BannerPosition.Top.ToString()));
            Banner? bannerBottom = _context.Banners.FirstOrDefault(b => b.BannerPosition.Equals(BannerPosition.Bottom.ToString()));

            CardIndexVM indexVM = new ()
            {
                BannerTopVM = _mapper.Map<BannerTopVM>(bannerTop),
                BannerBottomVM = _mapper.Map<BannerBottomVM>(bannerBottom)
            };

            return View(indexVM);
        }
    }
}
