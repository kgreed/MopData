using System.Data.Entity;
namespace MopFW
{
    public class MopContextFW : DbContext
    {
        public DbSet<Mop> Mops { get; set; }
    }
}
