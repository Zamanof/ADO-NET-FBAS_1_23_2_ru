using Microsoft.EntityFrameworkCore;

namespace ADO_07._Fluent_API;

internal class ApplicationContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Departament> Departaments { get; set; }
    public DbSet<Faculty> Faculties { get; set; }

    public ApplicationContext()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;
Database=AcademyWithFluentApi; 
Integrated Security=SSPI");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Group
        modelBuilder.Entity<Group>().Property(x => x.GroupName).HasMaxLength(10);
        modelBuilder.Entity<Group>().HasIndex(x => x.GroupName).IsUnique();
        modelBuilder.Entity<Group>().Property(x => x.Id).ValueGeneratedOnAdd();
        modelBuilder.Entity<Group>()
            .ToTable(x => x.HasCheckConstraint("CK_Group_GroupRating", "GroupRating>=0 AND GroupRating<=12"));




        // Teacher
        modelBuilder.Entity<Teacher>()
            .Property(x => x.TeacherId)
            .HasColumnName("Id")
            .ValueGeneratedOnAdd();
        modelBuilder.Entity<Teacher>()
            .HasIndex(x=>x.Email)
            .IsUnique();
        modelBuilder.Entity<Teacher>()
            .Property(x => x.Email)
            .IsRequired();
        modelBuilder.Entity<Teacher>()
            .Property(x => x.Bonus)
            .HasDefaultValue(0);
        modelBuilder.Entity<Teacher>()
            .Property(x => x.Salary)
            .HasDefaultValue(345);
        modelBuilder.Entity<Teacher>()
            .Property(x=> x.FirstName)
            .HasMaxLength(50)
            .IsRequired().HasColumnType("varchar");
        modelBuilder.Entity<Teacher>()
            .Property(x=> x.LastName)
            .HasMaxLength(50)
            .IsRequired();

        // Student
        modelBuilder.Entity<Student>()
            .HasOne(s => s.Group)
            .WithMany(g => g.Students)
            .HasForeignKey(s => s.GroupId)
            .OnDelete(DeleteBehavior.NoAction)
            .HasConstraintName("FK_Groups");
    }
}
