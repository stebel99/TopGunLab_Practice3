namespace TopGunLab_Practice3.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Quantity { get; set; }
        public string Description { get; set; }
        public Product()
        {
            Name = "";
            Quantity = "";
            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum";
        }
    }
}