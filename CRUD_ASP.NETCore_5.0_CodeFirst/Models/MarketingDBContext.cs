using Microsoft.EntityFrameworkCore;

namespace CRUD_ASP.NETCore_5._0_CodeFirst.Models
{
    public class MarketingDBContext : DbContext
    {
        public MarketingDBContext(DbContextOptions<MarketingDBContext> options) : base(options)
        { 
            
        }
        public DbSet<Product> Products { get; set; }
    }
}
