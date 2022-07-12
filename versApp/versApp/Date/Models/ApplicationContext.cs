using Microsoft.EntityFrameworkCore;

namespace versApp.Date.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) {}

        public DbSet<Order> Order { get; set; }
        

    }
}
