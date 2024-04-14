namespace Infrastructure.Models;

public class InitializeCourseDataModel
{
    public string Title { get; set; } = null!;

    public string OriginalPrice { get; set; } = null!;
    public string? DiscountPrice { get; set; }
    
    public int Hours { get; set; }
    public string LikesInPercent { get; set; } = null!;
    public string NumberOfLikes { get; set; } = null!;
    public bool IsBestseller { get; set; }
    public int ImageId { get; set; }
    public int CategoryId { get; set; }


}
