using OnlineShoppingCart.Models;
using System.ComponentModel.DataAnnotations;
public class AppRole :SharedModel
{
    [Required]
    public string Name { get; set; }
    public ICollection<AppUser> Users { get; set; }
}
