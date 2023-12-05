using System.ComponentModel.DataAnnotations;

namespace Proper.Areas.Admin.ViewModels.Banners
{
    public class BannerEditVM
    {
        public int Id { get; set; }
        [Required]
        public IFormFile? Image { get; set; } 
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string? ButtonText { get; set; }
        public string? BannerPosition { get; set; }
    }
}
