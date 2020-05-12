using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
// using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Tobacco_Shop.Models;

namespace Tobacco_Shop.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
        public DbSet<Tobacco> Tobaccos {get; set;}
        public DbSet<Category> Category {get; set;}
        public DbSet<ShoppingCart> ShoppingCarts {get; set;}
        public DbSet<Order> Orders {get; set;}
        public DbSet<OrderDetail> OrderDetails {get; set;}
    }
}