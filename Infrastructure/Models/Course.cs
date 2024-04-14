using Infrastructure.Entities;
using Infrastructure.Models.ViewModels.Components;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Models;

public class Course
{
    public string Title { get; set; } = null!;
    public string OriginalPrice { get; set; } = null!;
    public string? DiscountPrice { get; set; }
    public int Hours { get; set; }
    public string LikesInProcent { get; set; } = null!;
    public string NumberOfLikes { get; set; } = null!;
    public bool IsBestseller { get; set; }
    public DateTime Created { get; set; }
    public DateTime LastUpdated { get; set; }
    public Image Image { get; set; } = null!;
    public int CategoryId { get; set; }
    public List<Author> Authors { get; set; } = null!;
}
