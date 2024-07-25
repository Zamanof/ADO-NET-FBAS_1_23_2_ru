using Microsoft.EntityFrameworkCore;

namespace ADO_08._Read_Data._LazyLoading;

internal class ApplicationContext: DbContext
{
    public ApplicationContext()
    {
        Database.EnsureCreated();
    }
    public DbSet<Student> Students { get; set; }
    public DbSet<Group> Groups { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseLazyLoadingProxies()
            .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=LazyLoading;");
    }
}
