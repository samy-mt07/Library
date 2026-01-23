using Library.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library.Infrastructure.Data
{
    public class BibliothequeDbContext : DbContext
    {
        public BibliothequeDbContext() { }

        public BibliothequeDbContext(DbContextOptions<BibliothequeDbContext> options)
            : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
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
            
            modelBuilder.Entity<Emprunt>()
                .HasOne(e => e.Usager)
                .WithMany(u => u.Emprunts) // ✅ CORRECT
                .HasForeignKey(e => e.UsagerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Emprunt>()
                .HasOne(e => e.Livre)
                .WithMany(l => l.Emprunts)
                .HasForeignKey(e => e.LivreId)
                .OnDelete(DeleteBehavior.Restrict);

            // =========================
            // Participation (N-N)
            // =========================
            modelBuilder.Entity<Participation>()
                .HasKey(p => new { p.UsagerId, p.ActiviteId });

            modelBuilder.Entity<Participation>()
                .HasOne(p => p.Usager)
                .WithMany(u => u.Participations)
                .HasForeignKey(p => p.UsagerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Participation>()
                .HasOne(p => p.Activite)
                .WithMany(a => a.Participations)
                .HasForeignKey(p => p.ActiviteId)
                .OnDelete(DeleteBehavior.Cascade);

            
            // =========================
            modelBuilder.Entity<EmpruntMateriel>()
                .HasOne(e => e.Materiel)
                .WithMany(m => m.Emprunts) // ✅ mieux (et cohérent avec Materiel.Emprunts)
                .HasForeignKey(e => e.MaterielId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<EmpruntMateriel>()
                .HasOne(e => e.Usager)
                .WithMany() // si tu n'as pas Usager.EmpruntsMateriel
                .HasForeignKey(e => e.UsagerId)
                .OnDelete(DeleteBehavior.Restrict);

    
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
}
