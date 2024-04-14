using Infrastructure.Factories;
using Infrastructure.Models;
using Infrastructure.Models.ViewModels.Components;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class CourseService(CourseRepo courseRepo)
{
    private readonly CourseRepo _courseRepo = courseRepo;

    public async Task<List<CourseCard>> GetAllCoursesAsync()
    {
        try
        {
            var courses = await _courseRepo.GetAll().ToListAsync();
            return CourseFactory.Create(courses);
        }
        catch { }

        return null!;
    }

    public async Task<CoursesResult> GetCoursesAsync(string category, string searchQuery, int pageNumber, int pageSize)
    {
        var query = _courseRepo.GetAll();

        if (!string.IsNullOrEmpty(searchQuery))
            query = query.Where(x => x.Title.Contains(searchQuery) || (x.Authors.Any(x => x.FirstName.Contains(searchQuery) || x.LastName.Contains(searchQuery))));

        if (!string.IsNullOrEmpty(category) && category != "all")
            query = query.Where(x => x.Category!.CategoryName == category);

        query = query.OrderByDescending(c => c.LastUpdated);

        var totalItemCount = await query.CountAsync();
        var totalPages = (int)Math.Ceiling(totalItemCount / (double)pageSize);
        var courses = await query.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();

        return new CoursesResult
        {
            Courses = CourseFactory.Create(courses),
            TotalCount = totalItemCount,
            TotalPages = totalPages,
        };
    }
}
