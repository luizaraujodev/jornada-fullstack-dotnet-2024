using System.ComponentModel.DataAnnotations;
using Fina.Core.Enums;

namespace Fina.Core.Requests.Transactions;

public class UpdateTransactionRequest
{
    [Required(ErrorMessage = "O Id da transação deve ser informado.")]
    public long Id { get; set; }
    
    [Required(ErrorMessage = "Título inválido")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Típo inválido")]
    public ETransactionType Type { get; set; } = ETransactionType.Withdraw;
    
    [Required(ErrorMessage = "Valor inválido")]
    public decimal Amount { get; set; }
    
    [Required(ErrorMessage = "Categoria inválida")]
    public long CategoryId { get; set; }
    
    public DateTime? PaidOrReceivedAt { get; set; }
}