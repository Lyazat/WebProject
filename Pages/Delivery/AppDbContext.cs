using Microsoft.EntityFrameworkCore;
using Yummyset.Pages.login;
using Yummyset.Pages.Model;

namespace Yummyset.Pages.Delivery
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Burger> Burgers { get; set; }
        public DbSet<Pizza> Pizza { get; set; }
        public DbSet<Sushi> Sushis { get; set; }
        public DbSet<Order> Orders  { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
