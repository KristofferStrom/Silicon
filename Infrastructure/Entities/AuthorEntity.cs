using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities;

public class AuthorEntity
{
    [Key]
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;

    public ICollection<CourseEntity>? Courses { get; set; }
}
