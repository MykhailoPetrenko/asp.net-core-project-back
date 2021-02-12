using Microsoft.EntityFrameworkCore;

namespace Party.DB
{
    public class AppDbContext: DbContext
    {
        //public DbSet<Party> Parties { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=party;Integrated Security=True");
        }
        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PreferencjaUczestnika>()
                .HasKey(pr => new { pr.IdPreferencja,pr.IdUczestnik });  
            modelBuilder.Entity<PreferencjaUczestnika>()
                .HasOne(bc => bc)
                .WithMany(b => b.BookCategories)
                .HasForeignKey(bc => bc.BookId);  
            modelBuilder.Entity<PreferencjaUczestnika>()
                .HasOne(bc => bc.Category)
                .WithMany(c => c.BookCategories)
                .HasForeignKey(bc => bc.CategoryId);
        }*/
    }
}