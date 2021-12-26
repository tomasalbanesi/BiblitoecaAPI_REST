using Microsoft.EntityFrameworkCore;
using BiblitoecaAPI_REST.Models;

namespace BiblitoecaAPI_REST.Utilities
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ModelConfig(modelBuilder);
        }

        private void ModelConfig(ModelBuilder modelBuilder)
        {
            new CategoryConfiguration(modelBuilder.Entity<Category>());
        }
    }
}
