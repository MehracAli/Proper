using Microsoft.AspNetCore.Identity;

namespace Proper.Core.Entities
{
    public class User : IdentityUser
    {
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string? Photo { get; set; }
    }
}
