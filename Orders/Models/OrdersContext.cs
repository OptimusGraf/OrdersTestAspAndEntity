using Microsoft.EntityFrameworkCore;

namespace Orders.Models
{
    public class OrdersContext:DbContext
    {
        public OrdersContext(DbContextOptions<OrdersContext> options):base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Order> Orders => Set<Order>();
     

    }
} 
