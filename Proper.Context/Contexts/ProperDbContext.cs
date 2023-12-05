using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Proper.Core.Entities;
using Proper.Core.Entities.Banners;

namespace Proper.Context.Contexts
{
    public class ProperDbContext : IdentityDbContext<User>
    {
        public ProperDbContext(DbContextOptions<ProperDbContext> options) : base(options)
        {
        }

        public DbSet<Banner>? Banners { get; set; }
    }
}
