 using OnlineShoppingCart.Models;
using System;
using System.Collections.Generic;
namespace OnlineShoppingCart.Models
{
    public class Order:SharedModel
    {
        // Other order-related properties
        public string UserId { get; set; }
        public AppUser User { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShippingAddress { get; set; }
        // Add other properties for payment specifics
    }
}