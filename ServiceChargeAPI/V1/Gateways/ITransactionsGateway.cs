using System.Collections.Generic;
using ServiceChargeAPI.V1.Domain;

namespace ServiceChargeAPI.V1.Gateways
{
    public interface ITransactionsGateway
    {
        List<Transaction> GetTransactionsByPropertyRef(string propertyRef);
    }
}
