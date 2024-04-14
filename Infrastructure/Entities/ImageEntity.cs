using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities;

public class ImageEntity
{
    [Key]
    public int Id { get; set; }
    public string Url { get; set; } = null!;
    public string AltText { get; set; } = null!;
}
