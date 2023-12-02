using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Proper.Areas.Admin.ViewModels.Banner;
using Proper.Areas.Admin.ViewModels.MainVMs;
using Proper.Context.Contexts;
using Proper.Core.Entities.Banners;

namespace Proper.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BannerController : Controller
    {
        private readonly ProperDbContext _context;
        private readonly IMapper _mapper;

        public BannerController(ProperDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            HomeCrudVM homeCrudVM = new ()
            {

            };

            return View(homeCrudVM);
        }

        [HttpPost]
        [IgnoreAntiforgeryToken]
        public async Task<IActionResult> Create([FromForm]BannerCreateVM bannerCreateVM)
        {
            if(!ModelState.IsValid) return RedirectToAction("Index", "Card");

            Banner newBanner = _mapper.Map<Banner>(bannerCreateVM);

            await _context.Banners.AddAsync(newBanner);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Card");
        }
    }
}
