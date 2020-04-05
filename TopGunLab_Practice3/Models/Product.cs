using System.ComponentModel.DataAnnotations;

namespace TopGunLab_Practice3.Models
{
    public class Product
    {
        [Required(ErrorMessage = "Please enter the name of the product")]
        [StringLength(50, MinimumLength = 3,ErrorMessage = "Length must be between 3 and 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the quantity of the product")]
        [Range(typeof(double),"0","100000",ErrorMessage = "Number must be between 0 and 100000 characters")]
        public double Quantity { get; set; }

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