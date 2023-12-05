using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Differencing;
using Microsoft.EntityFrameworkCore;
using Proper.Areas.Admin.ViewModels.Banners;
using Proper.Areas.Admin.ViewModels.MainVMs;
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
        public async Task<ActionResult> Edit(int Id, BannerEditVM bannerEditVM)
        {
            Banner? banner = await _context.Banners.FirstOrDefaultAsync(b => b.Id.Equals(Id));

            if (!bannerEditVM.Image.CheckFile(300))
            {
                return RedirectToAction("Index", "Card");
            }

            bannerEditVM.Id = Id;
            banner.ImageURL = await FileUpload.SaveFile(_env.WebRootPath, 
                                                        bannerEditVM.Image, 
                                                        "assets", "images","home","banners");
            _mapper.Map(bannerEditVM, banner);

            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Card");
        }
    }
}
