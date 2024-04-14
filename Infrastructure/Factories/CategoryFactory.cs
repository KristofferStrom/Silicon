using Infrastructure.Entities;
using Infrastructure.Models;

namespace Infrastructure.Factories;

public class CategoryFactory
{
    public static IEnumerable<Category> Create(IEnumerable<CategoryEntity> entities)
    {
        return entities.Select(c => new Category
        {
            CategoryName = c.CategoryName
        });
    }
}
