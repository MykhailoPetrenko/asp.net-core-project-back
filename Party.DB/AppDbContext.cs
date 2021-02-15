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
        public DbSet<UczestnikWydarzenie> UczestnikWydarzenie { get; set; }

        public DbSet<Zdjecie> Zdjecia { get; set; }
 


        
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            //Preferencja Uczestnika
            modelBuilder.Entity<PreferencjaUczestnika>()
                .HasKey(pr => new { pr.IdPreferencja,pr.IdUczestnik });  
            modelBuilder.Entity<PreferencjaUczestnika>()
                .HasOne(bc => bc.Preferencja)
                .WithMany(b => b.PreferencjaUczestnika)
                .HasForeignKey(bc => bc.IdPreferencja);  
            modelBuilder.Entity<PreferencjaUczestnika>()
                .HasOne(bc => bc.Uczestnik)
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
            //Wydarzenie Skarga Uczestnik
            modelBuilder.Entity<Skarga>()
              .HasKey(pr => new { pr.IdWydarzenie, pr.IdUczestnik });
            modelBuilder.Entity<Skarga>()
                .HasOne(bc => bc.Wydarzenie)
                .WithMany(b => b.Skarga)
                .HasForeignKey(bc => bc.IdWydarzenie);
            modelBuilder.Entity<Skarga>()
                .HasOne(bc => bc.Uczestnik)
                .WithMany(c => c.Skarga)
                .HasForeignKey(bc => bc.IdUczestnik);
            //Wydarzenie Kometaz
            modelBuilder.Entity<Kometaz>()
             .HasKey(pr => new { pr.IdWydarzenie, pr.IdUczestnik });
            modelBuilder.Entity<Kometaz>()
                .HasOne(bc => bc.Wydarzenie)
                .WithMany(b => b.Kometaze)
                .HasForeignKey(bc => bc.IdWydarzenie);
            modelBuilder.Entity<Kometaz>()
                .HasOne(bc => bc.Uczestnik)
                .WithMany(c => c.Kometaz)
                .HasForeignKey(bc => bc.IdUczestnik);
            //Wydarzenie Ocena
            modelBuilder.Entity<Ocena>()
             .HasKey(pr => new { pr.IdWydarzenie, pr.IdUczestnik });
            modelBuilder.Entity<Ocena>()
                .HasOne(bc => bc.Wydarzenie)
                .WithMany(b => b.Oceny)
                .HasForeignKey(bc => bc.IdWydarzenie);
            modelBuilder.Entity<Ocena>()
                .HasOne(bc => bc.Uczestnik)
                .WithMany(c => c.Ocena)
                .HasForeignKey(bc => bc.IdUczestnik);

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
            //Wydarzenie Uczestnik
            modelBuilder.Entity<UczestnikWydarzenie>()
                .HasKey(pr => new { pr.IdWydarzenie, pr.IdUczestnik });
            modelBuilder.Entity<UczestnikWydarzenie>()
                .HasOne(bc => bc.Wydarzenie)
                .WithMany(b => b.UczestnikWydarzenie)
                .HasForeignKey(bc => bc.IdWydarzenie);
            modelBuilder.Entity<UczestnikWydarzenie>()
                .HasOne(bc => bc.Uczestnik)
                .WithMany(c => c.UczestnikWydarzenie)
                .HasForeignKey(bc => bc.IdUczestnik);

            //Zdjecia
            modelBuilder.Entity<Tworca>()
                .HasMany(c => c.Zdjecies)
                .WithOne(e => e.Tworca)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Wydarzenie>()
               .HasMany(c => c.Zdjecies)
               .WithOne(e => e.Wydarzenie)
               .OnDelete(DeleteBehavior.SetNull);

        }
    }
}