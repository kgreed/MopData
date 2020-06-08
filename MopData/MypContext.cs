using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MopData
{
    public class MopContext :DbContext
    {
        public DbSet<Mop> Mops { get; set; }
    }
}
