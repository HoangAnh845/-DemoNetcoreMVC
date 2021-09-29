using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DemoMVC.Data;
using System;
using System.Linq;
namespace DemoMVC.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationContext>>()))
            {
                // Look for any movies.
                if (context.Student.Any())
                {
                    return;   // DB has been seeded
                }

                context.Student.AddRange(
                    new Student
                    {
                        studentID = 1033,                     
                        studentName = "Uông Hoàng Anh",
                        birthDay = DateTime.Parse("2000-4-18"),
                        Countryside = "Ha Noi",
                        // Rating = "A",
                    },

                    new Student
                    {
                        studentID = 1034,  
                        studentName = "Comedy",
                        birthDay = DateTime.Parse("1984-3-13"),
                        Countryside = "Ha Noi",
                        // Rating = "A",
                    },

                    new Student
                    {
                        studentID = 1035,
                        studentName = "Comedy",
                        birthDay = DateTime.Parse("1986-2-23"),
                        Countryside = "Ha Noi",
                        // Rating = "A",
                    },

                    new Student
                    {
                        studentID = 1036,
                        studentName = "Western",
                        birthDay = DateTime.Parse("1959-4-15"),
                        Countryside = "Ha Noi",
                        // Rating = "A",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}