using Microsoft.EntityFrameworkCore;

namespace SProject.Models
{
    public class GeneralContext : DbContext
    {
        public GeneralContext(DbContextOptions<GeneralContext> options) : base(options)
        { }
        //Def tablas
        public DbSet<Item> Item { get; set; } = null;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Def relations
        }
    }
}