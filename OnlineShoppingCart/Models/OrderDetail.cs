using OnlineShoppingCart.Models;
using System.Collections.Generic;
namespace OnlineShoppingCart.Models
{
    public class OrderDetail:SharedModel
    {
        // Other order detail-related properties
        public string ProductId { get; set; }
        public Product Product { get; set; }
        public string OrderId { get; set; }
        public Order Order { get; set; }
    }
}