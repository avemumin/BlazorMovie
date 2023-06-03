using System.ComponentModel.DataAnnotations;

namespace ComponentInActionBlazor.Shared.Data;

public class Genre
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Name is required and cannot be empty")]
    public string Name { get; set; }
}

