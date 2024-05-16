using Microsoft.EntityFrameworkCore;

public class VidhyalayaDbContext : DbContext
{
    public DbSet<Grade> grades{ get; set; }
    public DbSet<Student> Students{ get; set; }   
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = Vidhyalaya.db");
    }
}