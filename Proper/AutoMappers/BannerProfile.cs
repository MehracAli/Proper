using AutoMapper;
using Proper.Areas.Admin.ViewModels.Banner;
using Proper.Core.Entities.Banners;

namespace Proper.Business.Mappers
{
    public class BannerProfile : Profile
    {
        public BannerProfile()
        {
            CreateMap<Banner, BannerCreateVM>().ReverseMap();
        }
    }
}