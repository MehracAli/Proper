using AutoMapper;
using Proper.Areas.Admin.ViewModels.Banners;
using Proper.Core.Entities.Banners;
using Proper.ViewModels.HomeVMs;

namespace Proper.AutoMappers
{
    public class BannerProfile : Profile
    {
        public BannerProfile()
        {
            CreateMap<Banner, BannerTopVM>().ReverseMap();
            CreateMap<Banner, BannerBottomVM>().ReverseMap();
            CreateMap<Banner, BannerEditVM>().ReverseMap();
            CreateMap<Banner, BannerTopHomeVM>().ReverseMap();
            CreateMap<Banner, BannerBottomHomeVM>().ReverseMap();
        }
    }
}
