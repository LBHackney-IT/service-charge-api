using System.ComponentModel.DataAnnotations;

namespace ServiceChargeAPI.V1.Boundary
{
    public class ListTransactionsRequest
    {
        [Required] public string PropertyRef { get; set; }
    }
}
