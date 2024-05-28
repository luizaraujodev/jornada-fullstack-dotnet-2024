using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Categories;

public class UpdateCategoryRequest : Request
{
    [Required(ErrorMessage = "O Id da categoria deve ser informado.")]
    public long Id { get; set; }
    
    [Required(ErrorMessage = "Títuilo inválido")]
    [MaxLength(80, ErrorMessage = "O título deve conter até 80 caracteres")]
    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;
}