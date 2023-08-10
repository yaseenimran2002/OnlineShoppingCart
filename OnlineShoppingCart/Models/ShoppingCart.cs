namespace OnlineShoppingCart.Models
{
    public class ShoppingCart:SharedModel
    {
        // User-specific details
        public string UserId { get; set; }
        public AppUser User { get; set; }
        public ICollection<CartItem> CartItems { get; set; }
    }
}