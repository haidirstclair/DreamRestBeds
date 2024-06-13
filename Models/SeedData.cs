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
                                
                                Name = "DreamRest Queen Bed",
                                Material = "Solid Wood",
                                Mattress = "Memory Foam",
                                Color = "White",
                                Price = 899.99M,
                                Warranty = "5 years",
                                CountryOfOrigin = "USA",
                                AssemblyRequired = true,
                                InstallationRequired = false,
                                Durability = "High",
                                Design = "Modern",
                                Support = "Excellent",
                                Feature = "Adjustable Base",
                                MinLength = 200,
                                MaxLength = 210,
                                Height = 50,
                                BedWidth = 160,
                                MaxLoad = 300,
                                MattressLength = 200,
                                MattressWidth = 160,
                                PictureUrl = "https://i5.walmartimages.com/asr/16226b92-7023-43e1-9006-e9c52a282398.b4be772b826c6a6ac210ce57ece25052.jpeg",
                                SizeType = "Queen",
                                Description = "A comfortable and stylish queen bed with a solid wood frame and memory foam mattress."
                            },
            new Bads
            {
               
                Name = "Comfort King Bed",
                Material = "Metal",
                Mattress = "Spring",
                Color = "Black",
                Price = 1099.99M,
                Warranty = "10 years",
                CountryOfOrigin = "Germany",
                AssemblyRequired = true,
                InstallationRequired = true,
                Durability = "Very High",
                Design = "Classic",
                Support = "Firm",
                Feature = "Headboard Storage",
                MinLength = 210,
                MaxLength = 220,
                Height = 55,
                BedWidth = 180,
                MaxLoad = 350,
                MattressLength = 210,
                MattressWidth = 180,
                PictureUrl = "https://example.com/images/comfort-king.jpg",
                SizeType = "King",
                Description = "A luxurious king bed with a durable metal frame and firm spring mattress, perfect for any bedroom."
            },
            new Bads
            {
                
                Name = "Cozy Twin Bed",
                Material = "Composite Wood",
                Mattress = "Foam",
                Color = "Blue",
                Price = 499.99M,
                Warranty = "3 years",
                CountryOfOrigin = "Canada",
                AssemblyRequired = false,
                InstallationRequired = false,
                Durability = "Medium",
                Design = "Contemporary",
                Support = "Medium",
                Feature = "Underbed Storage",
                MinLength = 190,
                MaxLength = 200,
                Height = 45,
                BedWidth = 90,
                MaxLoad = 200,
                MattressLength = 190,
                MattressWidth = 90,
                PictureUrl = "https://example.com/images/cozy-twin.jpg",
                SizeType = "Twin",
                Description = "A cozy twin bed with a composite wood frame and foam mattress, ideal for kids and guests."
            },
            new Bads
            {
                
                Name = "Luxury Full Bed",
                Material = "Leather",
                Mattress = "Hybrid",
                Color = "Brown",
                Price = 1299.99M,
                Warranty = "8 years",
                CountryOfOrigin = "Italy",
                AssemblyRequired = true,
                InstallationRequired = false,
                Durability = "Very High",
                Design = "Luxury",
                Support = "Soft",
                Feature = "LED Lighting",
                MinLength = 200,
                MaxLength = 210,
                Height = 50,
                BedWidth = 140,
                MaxLoad = 280,
                MattressLength = 200,
                MattressWidth = 140,
                PictureUrl = "https://example.com/images/luxury-full.jpg",
                SizeType = "Full",
                Description = "A luxurious full bed with a leather frame and hybrid mattress, featuring integrated LED lighting."
            },
            new Bads
            {
                
                Name = "Classic Twin Bed",
                Material = "Pine Wood",
                Mattress = "Innerspring",
                Color = "Natural",
                Price = 399.99M,
                Warranty = "2 years",
                CountryOfOrigin = "Sweden",
                AssemblyRequired = false,
                InstallationRequired = false,
                Durability = "Medium",
                Design = "Classic",
                Support = "Medium",
                Feature = "Headboard Shelf",
                MinLength = 190,
                MaxLength = 200,
                Height = 45,
                BedWidth = 90,
                MaxLoad = 180,
                MattressLength = 190,
                MattressWidth = 90,
                PictureUrl = "https://example.com/images/classic-twin.jpg",
                SizeType = "Twin",
                Description = "A classic twin bed made of pine wood with an innerspring mattress, ideal for a traditional bedroom."
            },
            new Bads
            {
                
                Name = "Modern Full Bed",
                Material = "Metal and Wood",
                Mattress = "Gel Memory Foam",
                Color = "Grey",
                Price = 799.99M,
                Warranty = "5 years",
                CountryOfOrigin = "China",
                AssemblyRequired = true,
                InstallationRequired = false,
                Durability = "High",
                Design = "Modern",
                Support = "Firm",
                Feature = "USB Ports",
                MinLength = 200,
                MaxLength = 210,
                Height = 50,
                BedWidth = 140,
                MaxLoad = 300,
                MattressLength = 200,
                MattressWidth = 140,
                PictureUrl = "https://example.com/images/modern-full.jpg",
                SizeType = "Full",
                Description = "A modern full bed with a combination of metal and wood frame and gel memory foam mattress, featuring USB ports."
            },
            new Bads
            {
                
                Name = "Rustic Queen Bed",
                Material = "Reclaimed Wood",
                Mattress = "Latex",
                Color = "Brown",
                Price = 999.99M,
                Warranty = "7 years",
                CountryOfOrigin = "Australia",
                AssemblyRequired = true,
                InstallationRequired = false,
                Durability = "High",
                Design = "Rustic",
                Support = "Medium",
                Feature = "Built-in Nightstands",
                MinLength = 200,
                MaxLength = 210,
                Height = 50,
                BedWidth = 160,
                MaxLoad = 300,
                MattressLength = 200,
                MattressWidth = 160,
                PictureUrl = "https://example.com/images/rustic-queen.jpg",
                SizeType = "Queen",
                Description = "A rustic queen bed made from reclaimed wood with a latex mattress, featuring built-in nightstands."
            },
            new Bads
            {
                
                Name = "Elegant King Bed",
                Material = "Mahogany",
                Mattress = "Pocket Spring",
                Color = "Dark Brown",
                Price = 1499.99M,
                Warranty = "10 years",
                CountryOfOrigin = "Brazil",
                AssemblyRequired = true,
                InstallationRequired = true,
                Durability = "Very High",
                Design = "Elegant",
                Support = "Soft",
                Feature = "Canopy",
                MinLength = 210,
                MaxLength = 220,
                Height = 60,
                BedWidth = 180,
                MaxLoad = 350,
                MattressLength = 210,
                MattressWidth = 180,
                PictureUrl = "https://example.com/images/elegant-king.jpg",
                SizeType = "King",
                Description = "An elegant king bed with a mahogany frame and pocket spring mattress, featuring a canopy."
            },
            new Bads
            {
                
                Name = "Minimalist Platform Bed",
                Material = "Bamboo",
                Mattress = "Futon",
                Color = "Natural",
                Price = 599.99M,
                Warranty = "4 years",
                CountryOfOrigin = "Japan",
                AssemblyRequired = false,
                InstallationRequired = false,
                Durability = "Medium",
                Design = "Minimalist",
                Support = "Firm",
                Feature = "Eco-Friendly",
                MinLength = 200,
                MaxLength = 210,
                Height = 40,
                BedWidth = 140,
                MaxLoad = 250,
                MattressLength = 200,
                MattressWidth = 140,
                PictureUrl = "https://example.com/images/minimalist-platform.jpg",
                SizeType = "Full",
                Description = "A minimalist platform bed made from bamboo with a futon mattress, designed to be eco-friendly."
            },
            new Bads
            {
              
                Name = "Contemporary Sofa Bed",
                Material = "Fabric and Metal",
                Mattress = "Foam",
                Color = "Light Grey",
                Price = 899.99M,
                Warranty = "3 years",
                CountryOfOrigin = "USA",
                AssemblyRequired = true,
                InstallationRequired = false,
                Durability = "High",
                Design = "Contemporary",
                Support = "Medium",
                Feature = "Convertible",
                MinLength = 190,
                MaxLength = 200,
                Height = 45,
                BedWidth = 140,
                MaxLoad = 250,
                MattressLength = 190,
                MattressWidth = 140,
                PictureUrl = "https://example.com/images/contemporary-sofa.jpg",
                SizeType = "Full",
                Description = "A contemporary sofa bed with a fabric and metal frame and foam mattress, convertible from sofa to bed."
            }
                );
                context.SaveChanges();
            }
        }
    }
}
