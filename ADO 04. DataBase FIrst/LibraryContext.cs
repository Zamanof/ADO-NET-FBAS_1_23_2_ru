using Microsoft.EntityFrameworkCore;

namespace ADO_04._DataBase_FIrst;

internal class LibraryContext:DbContext
{
    public DbSet<Author> Authors { get; set; }
    public LibraryContext()
    {
        //Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string cs = @"Server=(localdb)\MSSQLLocalDB;Initial Catalog=Library;Integrated Security=SSPI;";
        optionsBuilder.UseSqlServer(cs);
    }


}
