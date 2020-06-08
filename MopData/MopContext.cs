using System.Data.Entity;
namespace MopFramework
{
    public class MopContext :DbContext
    {
        public DbSet<Mop> Mops { get; set; }
    }
}
