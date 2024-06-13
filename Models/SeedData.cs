using DreamRestBeds.Data;
using Microsoft.EntityFrameworkCore;

namespace DreamRestBeds.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DreamRestBedsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<DreamRestBedsContext>>()))
            {
                // Look for any movies.
                if (context.Bads.Any())
                {
                    return;   // DB has been seeded
                }
                context.Bads.AddRange(
                    new Bads
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M
                    },
                );
                context.SaveChanges();
            }
        }
    }
}
