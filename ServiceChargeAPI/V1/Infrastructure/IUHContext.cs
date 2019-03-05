using Microsoft.EntityFrameworkCore;
using ServiceChargeAPI.V1.Domain;

namespace UnitTests.V1.Infrastructure
{
    public interface IUHContext
    {
        DbSet<UhTransaction> UTransactions { get; set; }
    }
}
