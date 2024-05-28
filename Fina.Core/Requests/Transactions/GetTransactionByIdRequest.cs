using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Transactions;

public class GetTransactionByIdRequest : Request
{
    [Required(ErrorMessage = "O Id da transação deve ser informado.")]
    public long Id { get; set; }
}