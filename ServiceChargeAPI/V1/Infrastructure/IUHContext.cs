using Microsoft.EntityFrameworkCore;
using ServiceChargeAPI.V1.Domain;

namespace ServiceChargeAPI.V1.Infrastructure
{
    public interface IUHContext
    {
        DbSet<UhTransaction> UTransactions { get; set; }
    }
}
