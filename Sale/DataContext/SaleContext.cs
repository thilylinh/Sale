using Microsoft.EntityFrameworkCore;

namespace Sale.DataContext
{
    public class SaleContext :DbContext
    {
        public SaleContext(DbContextOptions<SaleContext> options) : base(options)
        {

        }

        // init db
        // public DbSet<>

    }
}
