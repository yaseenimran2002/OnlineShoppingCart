using System.ComponentModel.DataAnnotations;
namespace OnlineShoppingCart.Models
{
    public class Product:SharedModel
    {
        [Required]
        public string Slug { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public string CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<CartItem> CartItems { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}