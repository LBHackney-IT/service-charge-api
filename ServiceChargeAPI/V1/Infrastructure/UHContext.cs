using Microsoft.EntityFrameworkCore;
using ServiceChargeAPI.V1.Domain;

namespace ServiceChargeAPI.V1.Infrastructure
{
    public class UhContext : DbContext, IUHContext
    {
        public UhContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<UhTransaction> UTransactions { get; set; }
    }
}
