using Microsoft.EntityFrameworkCore;

namespace API4SQL
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
        public DbSet<Models.CustomerClass> Customer { get; set; }
        public DbSet<Models.TicketClass> Ticket { get; set; }
    }
    
}
