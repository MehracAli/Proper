namespace Proper.Core.Entities.Banners
{
    public class Banner:BaseEntity
    {
        public string ImageURL { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ButtonText { get; set; } = null!;
        public string BannerPosition { get; set; } = null!;
    }
}
