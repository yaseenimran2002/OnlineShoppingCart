using System.ComponentModel.DataAnnotations;
namespace OnlineShoppingCart.Models
{
    public class CartItem:SharedModel
    {
        [Required]
        public string ShoppingCartId { get; set; }
        public string ShoppingCart { get; set; }
        public string ProductId { get; set; }
        [Required]
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}