using Infrastructure.Contexts;
using Infrastructure.Entities;
using Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class CourseRepo(ApplicationIdentityContext context) : BaseRepo<CourseEntity>(context)
{
    private readonly ApplicationIdentityContext _context = context;
    public override IQueryable<CourseEntity> GetAll()
    {
        try
        {
            return _context.Courses
                .Include(c => c.Authors)
                .Include(c => c.Image)
                .Include(c => c.Category)
                .AsQueryable();
        }
        catch { }

        return null!;

    }
}
