using System.ComponentModel.DataAnnotations;
namespace OnlineShoppingCart.Models
{
    public class Category:SharedModel
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public string Status { get; set; }
        public string Logo { get; set; }
        public ICollection<Product> Products { get; set; }
    }
    public enum CategoryType
    {
        Category = 0,
        Brand = 10,
        blogs = 20
    }
}