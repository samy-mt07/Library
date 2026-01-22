using Library.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library.Infrastructure.Data
{
    public class BibliothequeDbContext : DbContext
    {
<<<<<<< HEAD
        public BibliothequeDbContext()
        {
        }

=======
>>>>>>> e80ee4aa827c85436f43b3d8139a9c038cd52199
        public BibliothequeDbContext(DbContextOptions<BibliothequeDbContext> options)
            : base(options)
        {
        }

<<<<<<< HEAD
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Garde ceci seulement si tu n'utilises pas DI/appsettings.
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=localhost;Database=BibliothequeDb;Trusted_Connection=True;TrustServerCertificate=True;"
                );
            }
        }

        public DbSet<Livre> Livres { get; set; } = null!;
        public DbSet<Usager> Usagers { get; set; } = null!;
        public DbSet<Emprunt> Emprunts { get; set; } = null!;
        public DbSet<Activite> Activites { get; set; } = null!;
        public DbSet<Participation> Participations { get; set; } = null!;
        public DbSet<Materiel> Materiels { get; set; } = null!;
        public DbSet<EmpruntMateriel> EmpruntsMateriel { get; set; } = null!;
        public DbSet<Evaluation> Evaluations { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // =========================
            // Emprunt (historique)
            // =========================
            modelBuilder.Entity<Emprunt>()
                .HasOne(e => e.Usager)
                .WithMany(u => u.Emprunts)              // ✅ correspond à Usager.Emprunts
                .HasForeignKey(e => e.UsagerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Emprunt>()
                .HasOne(e => e.Livre)
                .WithMany(l => l.Emprunts)             // ✅ correspond à Livre.Emprunts
                .HasForeignKey(e => e.LivreId)
                .OnDelete(DeleteBehavior.Restrict);

            // =========================
            // Participation (N-N)
            // =========================
            modelBuilder.Entity<Participation>()
                .HasKey(p => new { p.UsagerId, p.ActiviteId });

            modelBuilder.Entity<Participation>()
                .HasOne(p => p.Usager)
                .WithMany(u => u.Participations)       // ✅ correspond à Usager.Participations
                .HasForeignKey(p => p.UsagerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Participation>()
                .HasOne(p => p.Activite)
                .WithMany(a => a.Participations)       // ✅ correspond à Activite.Participations
                .HasForeignKey(p => p.ActiviteId)
                .OnDelete(DeleteBehavior.Cascade);

            // =========================
            // EmpruntMateriel (si tu l'utilises)
            // =========================
            modelBuilder.Entity<EmpruntMateriel>()
    .HasOne(e => e.Materiel)
    .WithMany()
    .HasForeignKey(e => e.MaterielId)
    .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<EmpruntMateriel>()
                .HasOne(e => e.Usager)
                .WithMany()
                .HasForeignKey(e => e.UsagerId)
                .OnDelete(DeleteBehavior.Restrict);


            // =========================
            // Evaluation (unique Usager+Livre)
            // =========================
            modelBuilder.Entity<Evaluation>()
                .HasIndex(e => new { e.UsagerId, e.LivreId })
                .IsUnique();

            modelBuilder.Entity<Evaluation>()
                .HasOne(e => e.Usager)
                .WithMany()
                .HasForeignKey(e => e.UsagerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Evaluation>()
                .HasOne(e => e.Livre)
                .WithMany()
                .HasForeignKey(e => e.LivreId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
    }
=======
        public DbSet<Livre> Livres => Set<Livre>();
        public DbSet<Usager> Usagers => Set<Usager>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Livre>().HasKey(x => x.Id);
            modelBuilder.Entity<Usager>().HasKey(x => x.Id);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Emprunt>()
                .HasOne(e => e.Usager)
                .WithMany() // plus tard on peux mettre Usager.Emprunts
                .HasForeignKey(e => e.UsagerId)
                .OnDelete(DeleteBehavior.Restrict); // historique

            modelBuilder.Entity<Emprunt>()
                .HasOne(e => e.Livre) 
                .WithMany()
                .HasForeignKey(e => e.LivreId) 
                .OnDelete(DeleteBehavior.Restrict); // historique

            modelBuilder.Entity<Participation>()
       .HasKey(p => new { p.UsagerId, p.ActiviteId }); // PK composite

            modelBuilder.Entity<Participation>()
                .HasOne(p => p.Usager)
                .WithMany() // plus tard: Usager.Participations
                .HasForeignKey(p => p.UsagerId)
                .OnDelete(DeleteBehavior.Restrict); // historique / securite

            modelBuilder.Entity<Participation>()
                .HasOne(p => p.Activite)
                .WithMany(a => a.Participations)
                .HasForeignKey(p => p.ActiviteId)
                .OnDelete(DeleteBehavior.Cascade); // supprimer activité => supprimer participations 
        }
       

        public DbSet<Usager> Usager { get; set; }
        public DbSet<Livre> Livre { get; set; } 

        public DbSet<Emprunt> Emprunts { get; set; } //  AJOUT

        public DbSet<Activite> Activites { get; set; }
        public DbSet<Participation> Participations { get; set; }

    }

>>>>>>> e80ee4aa827c85436f43b3d8139a9c038cd52199
}
