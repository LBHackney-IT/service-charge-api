using System.Collections.Generic;
using ServiceChargeAPI.V1.Domain;

namespace UnitTests.V1.Gateways
{
    public interface ITransactionsGateway
    {
        List<Transaction> GetTransactionsByPropertyRef(string propertyRef);
    }
}
