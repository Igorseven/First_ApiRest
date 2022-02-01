using Microsoft.EntityFrameworkCore;
using SaveCars.Domain.Entities;

namespace SaveCars.Data.EntityFramework.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Fabricator> Fabricators { get; set; }
        public DbSet<Document> Documents { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContext) : base(dbContext)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
