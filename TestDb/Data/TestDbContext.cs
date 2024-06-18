using Microsoft.EntityFrameworkCore;
using TestDb.Models;

namespace TestDb.Data
{
    public class TestDbContext(DbContextOptions<TestDbContext> options) : DbContext(options)
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Document> Documents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Document>()
            //   .HasOne(d => d.OwnerEntity)
            //   .WithMany() // Assuming OwnerEntity doesn't have a back-reference to Document
            //   .HasForeignKey(d => d.OwnerGuid); // Use the OwnerGuid property as the foreign key

            //base.OnModelCreating(modelBuilder);
        }
    }
}




