using Microsoft.EntityFrameworkCore;
namespace mopcore
{
    public class MopContext : DbContext
    {
        public DbSet<Mop> Mops { get; set; }
    }
}