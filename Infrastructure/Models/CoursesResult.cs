using Infrastructure.Models.ViewModels.Components;

namespace Infrastructure.Models;

public class CoursesResult
{
    public int CurrentPage { get; set; }
    public int TotalPages { get; set; }
    public int PageSize { get; set; }
    public int TotalCount { get; set; }
    public IEnumerable<CourseCard>? Courses { get; set; }

    public void UpdateTotalPages()
    {
        TotalPages = (int)Math.Ceiling((double)TotalCount / PageSize);
    }
}
