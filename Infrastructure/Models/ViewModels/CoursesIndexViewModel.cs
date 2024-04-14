using Infrastructure.Models.ViewModels.Components;

namespace Infrastructure.Models.ViewModels;

public class CoursesIndexViewModel
{
    public List<Category> Categories { get; set; } = new();
    public List<CourseCard> Courses { get; set; } = new();
    public Pagination? Pagination { get; set; }

}
