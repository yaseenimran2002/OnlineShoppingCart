using System.ComponentModel.DataAnnotations;
namespace OnlineShoppingCart.Models
{
    public class AppUser : SharedModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        // Other user-related properties
        [Required]
        public string PasswordHash { get; set; }
        public ICollection<CartItem> CartItems { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<AppRole> Roles { get; set; }
    }
}