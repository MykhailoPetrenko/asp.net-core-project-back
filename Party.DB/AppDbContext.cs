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
    }
}