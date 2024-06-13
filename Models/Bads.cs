using System.ComponentModel.DataAnnotations;

namespace DreamRestBeds.Models
{
    public class Bads
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string? Name { get; set; }

        [Display(Name = "Material")]
        public string? Material { get; set; }

        [Display(Name = "Mattress")]
        public string? Mattress { get; set; }

        [Display(Name = "Color")]
        public string? Color { get; set; }

        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Display(Name = "Warranty")]
        public string? Warranty { get; set; }

        [Display(Name = "Country of Origin")]
        public string? CountryOfOrigin { get; set; }

        [Display(Name = "Assembly Required")]
        public bool AssemblyRequired { get; set; }

        [Display(Name = "Installation Required")]
        public bool InstallationRequired { get; set; }

        [Display(Name = "Durability")]
        public string? Durability { get; set; }

        [Display(Name = "Design")]
        public string? Design { get; set; }

        [Display(Name = "Support")]
        public string? Support { get; set; }

        [Display(Name = "Feature")]
        public string? Feature { get; set; }

        [Display(Name = "Min Length (cm)")]
        public int MinLength { get; set; }

        [Display(Name = "Max Length (cm)")]
        public int MaxLength { get; set; }

        [Display(Name = "Height (cm)")]
        public int Height { get; set; }

        [Display(Name = "Bed Width (cm)")]
        public int BedWidth { get; set; }

        [Display(Name = "Max Load (kg)")]
        public int MaxLoad { get; set; }

        [Display(Name = "Mattress Length (cm)")]
        public int MattressLength { get; set; }

        [Display(Name = "Mattress Width (cm)")]
        public int MattressWidth { get; set; }

        [Display(Name = "Picture")]
        public string? PictureUrl { get; set; }

        [Display(Name = "Size Type")]
        public string? SizeType { get; set; }

        [Display(Name = "Description")]
        public string? Description { get; set; }
    }
}
