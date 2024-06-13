namespace DreamRestBeds.Models
{
    public class Bads
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Material { get; set; }

        public string? Mattress { get; set; }

        public string? Color { get; set; }

        public decimal Price { get; set; }

        public string? Warranty { get; set; }

        public string? CountryOfOrigin { get; set; }

        public bool AssemblyRequired { get; set; }

        public bool InstallationRequired { get; set; }

        public string? Durability { get; set; }

        public string? Design { get; set; }

        public string? Support { get; set; }

        public string? Feature { get; set; }

        public int MinLength { get; set; } // in cm

        public int MaxLength { get; set; } // in cm

        public int Height { get; set; } // in cm

        public int BedWidth { get; set; } // in cm

        public int MaxLoad { get; set; } // in kg

        public int MattressLength { get; set; } // in cm

        public int MattressWidth { get; set; } // in cm

        public string? PictureUrl { get; set; } // URL of the bed picture

        public string? SizeType { get; set; } // Size type (e.g., Twin, Full, Queen, King)

        public string? Description { get; set; } // Description of the bed
    }
}
