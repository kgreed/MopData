using System.Data.Entity;
namespace MopFW
{
    public class MopContext : DbContext
    {
        public DbSet<Mop> Mops { get; set; }
    }
}
