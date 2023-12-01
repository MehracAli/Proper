using Microsoft.EntityFrameworkCore;
using Proper.Core.Entities.Banners;

namespace Proper.Context.Contexts
{
    public class ProperDbContext:DbContext
    {
        public ProperDbContext(DbContextOptions<ProperDbContext> options) : base(options)
        {
        }

        public DbSet<Banner>? Banners { get; set; }
    }
}
