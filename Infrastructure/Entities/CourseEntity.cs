using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities;

public class CourseEntity
{
    [Key]
    public string Id { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string OriginalPrice { get; set; } = null!;
    public string? DiscountPrice { get; set; }
    public int Hours { get; set; }
    public string LikesInProcent { get; set; } = null!;
    public string NumberOfLikes { get; set; } = null!;
    public bool IsBestseller { get; set; }
    public DateTime Created { get; set; }
    public DateTime LastUpdated { get; set; }
    public int ImageId { get; set; }
    public ImageEntity Image { get; set; } = null!;
    public int? CategoryId { get; set; }
    public CategoryEntity Category { get; set; } = null!;

    public ICollection<AuthorEntity> Authors { get; set; } = null!;
}
