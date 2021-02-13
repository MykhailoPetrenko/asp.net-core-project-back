using Microsoft.EntityFrameworkCore;

namespace Party.DB
{
    public class AppDbContext: DbContext
    {
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

/*        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=party;Integrated Security=True");
        }*/
        
        public DbSet<Uczestnik> Uczestnik { get; set; }
        public DbSet<Preferencja> Preferencja { get; set; }
        public DbSet<PreferencjaUczestnika> PreferencjaUczestnika { get; set; }
        
        public DbSet<Tworca> Tworca { get; set; }

        public DbSet<Wydarzenie> Wydarzenies { get; set; }
        public DbSet<Miejsce> Miejsca { get; set; }
        public DbSet<WydarzenieMiejsce> WydarzenieMiejsce { get; set; }
        
        public DbSet<Skarga> Skarga { get; set; }
        public DbSet<Kometaz> Kometaz { get; set; }
        public DbSet<Ocena> Ocena { get; set; }

        public DbSet<Kategoria> Kategoria { get; set; }
        public DbSet<WydarzenieKategoria> WydarzenieKategoria { get; set; }


        
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Preferencja Uczestnika
            modelBuilder.Entity<PreferencjaUczestnika>()
                .HasKey(pr => new { pr.IdPreferencja,pr.IdUczestnik });  
            modelBuilder.Entity<PreferencjaUczestnika>()
                .HasOne(bc => bc.IdPreferencjaNavigation)
                .WithMany(b => b.PreferencjaUczestnika)
                .HasForeignKey(bc => bc.IdPreferencja);  
            modelBuilder.Entity<PreferencjaUczestnika>()
                .HasOne(bc => bc.IdUczestnikNavigation)
                .WithMany(c => c.PreferencjaUczestnika)
                .HasForeignKey(bc => bc.IdUczestnik);
            //Tworca -> Wydarzenie
            modelBuilder.Entity<Tworca>()
                .HasMany(c => c.Wydarzenia)
                .WithOne(e => e.Tworca);
            //Wydarzenie Reklama
            
            //Wydarzenie Miejsce
            modelBuilder.Entity<WydarzenieMiejsce>()
                .HasKey(pr => new { pr.IdWydarzenie,pr.IdMiejsce });  
            modelBuilder.Entity<WydarzenieMiejsce>()
                .HasOne(bc => bc.IdWydarzenieNavigation)
                .WithMany(b => b.WydarzenieMiejsce)
                .HasForeignKey(bc => bc.IdWydarzenie);  
            modelBuilder.Entity<WydarzenieMiejsce>()
                .HasOne(bc => bc.IdMiejsceNavigation)
                .WithMany(c => c.WydarzenieMiejsce)
                .HasForeignKey(bc => bc.IdMiejsce);
            //Wydarzenie Skarga
            modelBuilder.Entity<Wydarzenie>()
                .HasMany(c => c.Skarga)
                .WithOne(e => e.Wydarzenie);
            //Wydarzenie Kometaz
            modelBuilder.Entity<Wydarzenie>()
                .HasMany(c => c.Kometaze)
                .WithOne(e => e.Wydarzenie);
            //Wydarzenie Ocena
            modelBuilder.Entity<Wydarzenie>()
                .HasMany(c => c.Oceny)
                .WithOne(e => e.Wydarzenie);

            //Wydarzenie KAtegoria
            modelBuilder.Entity<WydarzenieKategoria>()
                .HasKey(pr => new { pr.IdWydarzenie, pr.IdKategoria });
            modelBuilder.Entity<WydarzenieKategoria>()
                .HasOne(bc => bc.IdWydarzenieNavigation)
                .WithMany(b => b.WydarzenieKategoria)
                .HasForeignKey(bc => bc.IdWydarzenie);
            modelBuilder.Entity<WydarzenieKategoria>()
                .HasOne(bc => bc.IdKategoriaNavigation)
                .WithMany(c => c.WydarzenieKategoria)
                .HasForeignKey(bc => bc.IdKategoria);

        }
    }
}