using System.ComponentModel.DataAnnotations;

namespace Proper.Areas.Admin.ViewModels.Banner
{
    public class BannerCreateVM
    {
        [Required]
        public IFormFile? Image { get; set; } = null!;

        [Required, MaxLength(30, ErrorMessage = "Title caanot be longer than 30 characters")]
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        
        [Required, MaxLength(15, ErrorMessage = "Button Text caanot be longer than 30 characters")]
        public string ButtonText { get; set; } = null!;

        [Required]
        public string BannerType { get; set; } 
    }
}
