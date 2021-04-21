using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcClassroom.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcClassroom.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcClassroomContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcClassroomContext>>()))
            {
                // Look for any classes.
                if (context.Classes.Any())
                {
                    return;   // DB has been seeded
                }

                context.Classes.AddRange(
                    new Class
                    {
                        Title = "Software Engineering",
                        ExamDate = DateTime.Parse("2021-6-11")
                    },

                    new Class
                    {
                        Title = "Microprocessor Design",
                        ExamDate = DateTime.Parse("2021-6-12")
                    },

                    new Class
                    {
                        Title = "Parallel and Distributed Algorithms",
                        ExamDate = DateTime.Parse("2021-6-13")
                    },

                    new Class
                    {
                        Title = "Formal Languages and Automata",
                        ExamDate = DateTime.Parse("2021-6-14")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
