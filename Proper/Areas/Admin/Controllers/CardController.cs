using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proper.Areas.Admin.ViewModels.BannerVMs;
using Proper.Areas.Admin.ViewModels.MainVMs;
using AutoMapper;
using Proper.Context.Contexts;

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

        public async Task<IActionResult> Index()
        {
            HomeCrudVM homeCrudVM = new()
            {
                BannersVM = await _context.Banners.Select(b => new BannerCrudVM()
                {
                    ImageURL = b.ImageURL,
                    Title = b.Title,
                    Description = b.Description,
                    ButtonText = b.Title,
                    BannerType = b.BannerType,

                }).ToListAsync()
            };
            return View(homeCrudVM);
        }
    }
}
