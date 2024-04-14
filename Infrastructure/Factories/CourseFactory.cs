using Infrastructure.Entities;
using Infrastructure.Models;
using Infrastructure.Models.ViewModels.Components;

namespace Infrastructure.Factories;

public class CourseFactory
{
    public static CourseEntity Create(Course course)
    {
        var dateTime = DateTime.Now;
        try
        {
            return new CourseEntity
            {
                Id = Guid.NewGuid().ToString(),
                Title = course.Title,
                Authors = AuthorFactory.Create(course.Authors),
                Image = ImageFactory.Create(course.Image),
                CategoryId = course.CategoryId,
                Created = dateTime,
                LastUpdated = dateTime,
                DiscountPrice = course.DiscountPrice,
                IsBestseller = course.IsBestseller,
                LikesInProcent = course.LikesInProcent,
                NumberOfLikes = course.NumberOfLikes,
                OriginalPrice = course.OriginalPrice,
                Hours = course.Hours

            };
        }
        catch { }
        return null!;
    }

    public static CourseCard Create(CourseEntity course)
    {
        try
        {
            return new CourseCard
            {
                Title = course.Title,
                OriginalPrice = course.OriginalPrice,
                DiscountPrice = course.DiscountPrice,
                Hours = course.Hours,
                LikesInProcent = course.LikesInProcent,
                NumberOfLikes = course.NumberOfLikes,
                IsBestSeller = course.IsBestseller,
                Image = ImageFactory.Create(course.Image),
                Authors = AuthorFactory.Create(course.Authors)
            };
        }
        catch { }
        return null!;
    }

    public static List<CourseCard> Create(List<CourseEntity> courses)
    {
        var courseCards = new List<CourseCard>();
        foreach (var course in courses)
        {
            courseCards.Add(Create(course));
        }
        return courseCards;
    }



}
