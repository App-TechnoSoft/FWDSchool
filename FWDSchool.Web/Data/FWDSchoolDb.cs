using Microsoft.EntityFrameworkCore;

public class FWDSchoolDb : DbContext
{       
    public DbSet<Student> Students { get; set; }
    public DbSet<Tutorial> Tutorials { get; set; }
    public DbSet<TutorialSection> TutorialSections { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=FWDSchoolDb;Trusted_Connection=True;");
    }
} 