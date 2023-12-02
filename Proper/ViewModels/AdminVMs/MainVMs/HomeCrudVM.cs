using Proper.Areas.Admin.ViewModels.Banner;
using Proper.Areas.Admin.ViewModels.BannerVMs;

namespace Proper.Areas.Admin.ViewModels.MainVMs
{
    public class HomeCrudVM
    {
        public IEnumerable<BannerCrudVM>? BannersVM { get; set; }
        public BannerCreateVM? BannerCreateVM { get; set; }
        public BannerEditVM? BannerEditVM { get; set; }
    }
}
