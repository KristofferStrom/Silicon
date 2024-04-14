namespace Infrastructure.Models.ViewModels.Components;

public class CourseCard
{
    public string Title { get; set; } = null!;
    public Image Image { get; set; } = null!;
    public bool IsBestSeller { get; set; }
    public string OriginalPrice { get; set; } = null!;
    public string? DiscountPrice { get; set; }
    public int Hours { get; set; }
    public string LikesInProcent { get; set; } = null!;
    public string NumberOfLikes { get; set; } = null!;
    public List<Author> Authors { get; set; } = null!;

    public string GetAuthorNames()
    {
        var authorNames = "";
        foreach (var author in Authors)
        {
            authorNames += author.FirstName + " " + author.LastName + " & ";
        }
        return authorNames.TrimEnd('&', ' ');
    }
}
