using Microsoft.EntityFrameworkCore;

namespace ADO_06._Entity_relationships;

internal class StudentContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<StudentCard> StudentCards { get; set; }
    public StudentContext() 
    { 
        Database.EnsureCreated(); 
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;
Database=OneToOne; 
Integrated Security=SSPI");
    }
}
