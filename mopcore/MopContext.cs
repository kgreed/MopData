using Microsoft.EntityFrameworkCore;
namespace MopCore
{
    public class MopContext : DbContext
    {
        public DbSet<Mop> Mops { get; set; }
    }
}