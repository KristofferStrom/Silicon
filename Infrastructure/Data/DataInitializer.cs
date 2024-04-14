using Infrastructure.Contexts;
using Infrastructure.Entities;
using Infrastructure.Factories;
using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace Infrastructure.Configurations
{
    public static class DataInitializer
    {
        public static void InitializeData(ApplicationIdentityContext context)
        {
            context.Database.Migrate();

           
            SeedCourses(context);
        }

        private static void SeedCourses(ApplicationIdentityContext context)
        {
            var dateTime = DateTime.Now;

            CreateCourseIfNotExists(context, new InitializeCourseDataModel 
            {
                Title = "Fullstack Web Developer Course from Scratch",
                OriginalPrice = "$12.50",
                Hours = 220,
                LikesInPercent = "94%",
                NumberOfLikes = "4.2K",
                IsBestseller = true,
                ImageId = 2,
                CategoryId = 2
            });
            CreateCourseIfNotExists(context, new InitializeCourseDataModel
            {
                Title = "HTML, CSS, JavaScript Web Developer",
                OriginalPrice = "$15.99",
                Hours = 160,
                LikesInPercent = "92%",
                NumberOfLikes = "3.1K",
                IsBestseller = false,
                ImageId = 4,
                CategoryId = 1
            });
            CreateCourseIfNotExists(context, new InitializeCourseDataModel
            {
                Title = "The Complete Front-End Web Development Course",
                OriginalPrice = "$44.99",
                DiscountPrice = "$9.99",
                Hours = 100,
                LikesInPercent = "98%",
                NumberOfLikes = "2.7K",
                IsBestseller = false,
                ImageId = 5,
                CategoryId = 1
            });
            CreateCourseIfNotExists(context, new InitializeCourseDataModel
            {
                Title = "iOS & Swift - The Complete iOS App Development Course",
                OriginalPrice = "$15.99",
                Hours = 160,
                LikesInPercent = "92%",
                NumberOfLikes = "3.1K",
                IsBestseller = false,
                ImageId = 6,
                CategoryId = 2
            });
            CreateCourseIfNotExists(context, new InitializeCourseDataModel
            {
                Title = "Data Science & Machine Learning with Python",
                OriginalPrice = "$11.20",
                Hours = 160,
                LikesInPercent = "92%",
                NumberOfLikes = "3.1K",
                IsBestseller = true,
                ImageId = 7,
                CategoryId = 3
            });
            CreateCourseIfNotExists(context, new InitializeCourseDataModel
            {
                Title = "Creative CSS Drawing Course: Make Art With CSS",
                OriginalPrice = "$10.50",
                Hours = 220,
                LikesInPercent = "94%",
                NumberOfLikes = "4.2K",
                IsBestseller = false,
                ImageId = 8,
                CategoryId = 4
            });
            CreateCourseIfNotExists(context, new InitializeCourseDataModel
            {
                Title = "Blender Character Creator v2.0 for Video Games Design",
                OriginalPrice = "$18.99",
                Hours = 160,
                LikesInPercent = "92%",
                NumberOfLikes = "3.1K",
                IsBestseller = false,
                ImageId = 9,
                CategoryId = 4
            });
            CreateCourseIfNotExists(context, new InitializeCourseDataModel
            {
                Title = "The Ultimate Guide to 2D Mobile Game Development with Unity",
                OriginalPrice = "$44.99",
                DiscountPrice = "$12.99",
                Hours = 100,
                LikesInPercent = "98%",
                NumberOfLikes = "2.7K",
                IsBestseller = false,
                ImageId = 10,
                CategoryId = 2
            });
            CreateCourseIfNotExists(context, new InitializeCourseDataModel
            {
                Title = "Learn JMETER from Scratch on Live Apps-Performance Testing",
                OriginalPrice = "$14.50",
                Hours = 160,
                LikesInPercent = "92%",
                NumberOfLikes = "3.1K",
                IsBestseller = false,
                ImageId = 11,
                CategoryId = 5
            });
        }

        private static void CreateCourseIfNotExists(ApplicationIdentityContext context, InitializeCourseDataModel initializeCourseDataModel)
        {
            var course = context.Courses.FirstOrDefault(x => x.Title == initializeCourseDataModel.Title);
            if (course == null)
            {
                var dateTime = DateTime.Now;
                var courseEntity = new CourseEntity
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = initializeCourseDataModel.Title,
                    OriginalPrice = initializeCourseDataModel.OriginalPrice,
                    DiscountPrice = initializeCourseDataModel.DiscountPrice,
                    Hours = initializeCourseDataModel.Hours,
                    LikesInProcent = initializeCourseDataModel.LikesInPercent,
                    NumberOfLikes = initializeCourseDataModel.NumberOfLikes,
                    IsBestseller = initializeCourseDataModel.IsBestseller,
                    Created = dateTime,
                    LastUpdated = dateTime,
                    ImageId = initializeCourseDataModel.ImageId,
                    CategoryId = initializeCourseDataModel.CategoryId
                };
                context.Courses.Add(courseEntity);
                context.SaveChanges();
            }
        }



   
    }
}
