using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Reflection.Emit;
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

        }
    }
}

//modelBuilder
//    .Entity<Document>()
//    .Property(d => d.OwnerEntity)
//    .HasConversion(new EnumToStringConverter<FileOwnerEntity>());

//modelBuilder
//    .Entity<Document>()
//    .Property(d => d.OwnerEntity)
//    .HasConversion<string>();

//modelBuilder.Entity<Document>()
//  .Property(e => e.OwnerEntity)
//  .HasConversion(
//       v => v.ToString(),
//       v => (FileOwnerEntity)Enum.Parse(typeof(FileOwnerEntity), v));


