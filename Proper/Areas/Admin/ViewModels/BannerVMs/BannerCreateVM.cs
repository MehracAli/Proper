namespace Proper.Areas.Admin.ViewModels.Banner
{
    public class BannerCreateVM
    {
        public IFormFile? Image { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ButtonText { get; set; } = null!;
    }
}
