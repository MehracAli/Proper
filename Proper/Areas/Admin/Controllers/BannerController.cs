using AutoMapper;
using Microsoft.AspNetCore.Mvc;

using Proper.Areas.Admin.ViewModels.Banner;
using Proper.Areas.Admin.ViewModels.BannerVMs;
using Proper.Business.Utilities.Extensions;
using Proper.Context.Contexts;
using Proper.Core.Entities.Banners;

namespace Proper.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BannerController : Controller
    {
        private readonly ProperDbContext _context;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _env;

        public BannerController(ProperDbContext context, IMapper mapper, IWebHostEnvironment env)
        {
            _context = context;
            _mapper = mapper;
            _env = env;
        }

        [HttpPost]
        [IgnoreAntiforgeryToken]
        public async Task<IActionResult> Create([FromForm] BannerCreateVM bannerCreateVM)
        {
            if (!ModelState.IsValid) return RedirectToAction("Index", "Card");

            if (!bannerCreateVM.Image.CheckFile())
            {
                return RedirectToAction("Index", "Card");
            }

            Banner newBanner = _mapper.Map<Banner>(bannerCreateVM);
            newBanner.ImageURL = await FileUpload.SaveFile(_env.WebRootPath,
                                                           bannerCreateVM.Image,
                                                           "assets", "images", "home", "banners");

            await _context.Banners.AddAsync(newBanner);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Card");
        }
        
        public async Task<IActionResult> Edit([FromForm] BannerEditVM bannerEditVM)
        {
            return Json(bannerEditVM);
        }
    }
}
