namespace Fina.Core.Requests.Transactions;

public class GetTransactionsByIPeriodRequest : PagedRequest
{
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}