namespace Proper.Areas.Admin.ViewModels.Banners
{
    public class BannerVM
    {
        public int Id { get; set; }
        public string ImageURL { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ButtonText { get; set; } = null!;
        public string BannerPosition { get; set; } = null!;
    }
}
