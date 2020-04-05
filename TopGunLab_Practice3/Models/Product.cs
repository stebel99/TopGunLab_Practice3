using System.ComponentModel.DataAnnotations;

namespace TopGunLab_Practice3.Models
{
    public class Product
    {
        [Required, MinLength(5)]
        public string Name { get; set; }

        [Required]
        public double Quantity { get; set; }

        [Required]
        public Type Type { get; set; }
    }
    public enum Type
    {
        Pound,
        Gram,
        Kilogram,
        Ton,
        Litre,
        Pieces
    }
}