using Infrastructure.Models.ViewModels;
using Infrastructure.Models.ViewModels.Components;
using Infrastructure.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Authorize]
    public class CoursesController(CourseService courseService, CategoryService categoryService) : Controller
    {
        private readonly CourseService _courseService = courseService;
        private readonly CategoryService _categoryService = categoryService;

        public async Task<IActionResult> Index(string category = "", string searchQuery = "", int pageNumber = 1, int pageSize = 6)
        {
            var coursesResult = await _courseService.GetCoursesAsync(category, searchQuery, pageNumber, pageSize);
            var viewModel = new CoursesIndexViewModel
            {
                Courses = coursesResult.Courses!.ToList(),
                Categories = await _categoryService.GetAllCategoriesAsync(),
                Pagination = new Pagination
                {
                    PageSize = pageSize,
                    CurrentPage = pageNumber,
                    TotalPages = coursesResult.TotalPages,
                    TotalCount = coursesResult.TotalCount,
                }

            };
            return View(viewModel);
        }
    }
}
