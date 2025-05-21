using Microsoft.EntityFrameworkCore;

namespace Poteri_Davleniya.Data
{
    public class PoteriContext: DbContext
    {
        public DbSet<Variant> Variants { get; set; }

        public PoteriContext(DbContextOptions<PoteriContext> options) : base(options)
        { 
        
        }
    }
}
