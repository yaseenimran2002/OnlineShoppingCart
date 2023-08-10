using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineShoppingCart.Models;

namespace OnlineShoppingCart.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<AppRole> Role { get; set; } = default!;
        public DbSet<AppUser> User { get; set; } = default!;
        public DbSet<CartItem> Item { get; set; } = default!;
        public DbSet<Category> Category { get; set; } = default!;
        public DbSet<Order> Order { get; set; } = default!;
        public DbSet<OrderDetail> Detail { get; set; } = default!;
        public DbSet<Product> Product { get; set; } = default!;
        public DbSet<ProductDeal> Deal { get; set; } = default!;
        public DbSet<ShoppingCart> Cart { get; set; } = default!;




    }
}
