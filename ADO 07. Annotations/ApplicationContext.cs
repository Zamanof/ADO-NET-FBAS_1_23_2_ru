using Microsoft.EntityFrameworkCore;

namespace ADO_07._Annotations;

internal class ApplicationContext: DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Departament> Departaments { get; set;}
    public DbSet<Faculty> Faculties { get; set; }

    public ApplicationContext()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;
Database=AcademyWithAnotations; 
Integrated Security=SSPI").UseValidationCheckConstraints();
}
