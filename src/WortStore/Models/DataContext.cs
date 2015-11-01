using Microsoft.Data.Entity;
using WortStore.Models.Entities;

namespace WortStore.Models
{
  public class DataContext : DbContext
  {
    public DbSet<CustomWord> CustomWords { get; set; }
    public DbSet<Language> Languages { get; set; }
    public DbSet<Module> Modules { get; set; }
    public DbSet<User> Users { get; set; }
    public  DbSet<Word> Words { get; set; }
    public DbSet<WordDescription> WordDescriptions { get; set; } 
  }
}
