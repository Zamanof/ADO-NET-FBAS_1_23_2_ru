using Microsoft.EntityFrameworkCore;

namespace ADO_08._Migration;

internal class ApllicationContext: DbContext
{
    public DbSet<Student> Students { get; set; }
    public ApllicationContext()
    {
        //Database.EnsureDeleted();
        //Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Migrations;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>().Property(s => s.FirstName).IsRequired();
        modelBuilder.Entity<Student>().Property(s => s.LastName).IsRequired();
        

    }
}
