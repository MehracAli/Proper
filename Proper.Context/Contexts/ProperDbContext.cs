using Microsoft.EntityFrameworkCore;

namespace Proper.Context.Contexts
{
    public class ProperDbContext:DbContext
    {
        public ProperDbContext(DbContextOptions<ProperDbContext> options) : base(options)
        {
        }
    }
}
