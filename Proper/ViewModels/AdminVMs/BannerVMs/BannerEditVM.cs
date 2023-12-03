namespace Proper.Areas.Admin.ViewModels.BannerVMs
{
    public class BannerEditVM
    {
        public IFormFile Image { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ButtonText { get; set; } = null!;
        public string BannerType { get; set; }
    }
}
