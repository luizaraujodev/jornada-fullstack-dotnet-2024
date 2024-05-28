﻿using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Categories;

public class GetCategoryByIdRequest : Request
{
    [Required(ErrorMessage = "O Id da categoria deve ser informado.")]
    public long Id { get; set; }
}