using Microsoft.EntityFrameworkCore;
using RestaurantePizza.Models;

namespace RestaurantePizza.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<RestauranteModel> Restaurantes { get; set; }
        public DbSet<PizzaModel> Pizzas { get; set; }
    }
}
