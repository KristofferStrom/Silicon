using Infrastructure.Factories;
using Infrastructure.Models;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class CategoryService
{
    private readonly CategoryRepo _categoryRepo;

    public CategoryService(CategoryRepo categoryRepo)
    {
        _categoryRepo = categoryRepo;
    }

    public async Task<List<Category>> GetAllCategoriesAsync()
    {
        var categories = await _categoryRepo.GetAll().ToListAsync();
        return CategoryFactory.Create(categories).ToList();
    }
}
