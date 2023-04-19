using Microsoft.EntityFrameworkCore;

namespace Bulb.Models;
public class ApplicationContext : DbContext
{
    public DbSet<Note> Notes => Set<Note>();
    public ApplicationContext() => Database.EnsureCreated();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=helloapp.db");
    }
}