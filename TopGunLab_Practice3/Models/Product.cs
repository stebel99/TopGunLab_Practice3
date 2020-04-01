namespace TopGunLab_Practice3.Models
{
    public class Product
    {
        public string Name { get; set; }
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