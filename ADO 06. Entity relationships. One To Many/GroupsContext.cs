using Microsoft.EntityFrameworkCore;

namespace ADO_06._Entity_relationships._One_To_Many;

internal class GroupsContext : DbContext
{
    public DbSet<Group> Groups { get; set; }
    public DbSet<Student> Students { get; set; }

    public GroupsContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;
Database=OneToMany; 
Integrated Security=SSPI");
    }
}
