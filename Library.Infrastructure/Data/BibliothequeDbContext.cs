using Library.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library.Infrastructure.Data
{
    public class BibliothequeDbContext : DbContext
    {
        public BibliothequeDbContext()
        {
        }

        public BibliothequeDbContext(DbContextOptions<BibliothequeDbContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=localhost;Database=BibliothequeDb;Trusted_Connection=True;TrustServerCertificate=True;"
                );
            }
        }

        public DbSet<Livre> Livres => Set<Livre>();
        public DbSet<Usager> Usagers => Set<Usager>();
        public DbSet<Materiel> Materiels { get; set; }
        public DbSet<EmpruntMateriel> EmpruntsMateriel { get; set; }
        public DbSet<Evaluation> Evaluations { get; set; }


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
                .OnDelete(DeleteBehavior.Cascade);
            // supprimer activité => supprimer participations 
            modelBuilder.Entity<EmpruntMateriel>()
    .HasOne(e => e.Usager)
    .WithMany()
    .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Evaluation>()
    .HasIndex(e => new { e.UsagerId, e.LivreId })
    .IsUnique();

            modelBuilder.Entity<Evaluation>()
                .HasOne(e => e.Usager)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);


        }


        public DbSet<Usager> Usager { get; set; }
        public DbSet<Livre> Livre { get; set; } 

        public DbSet<Emprunt> Emprunts { get; set; } //  AJOUT

        public DbSet<Activite> Activites { get; set; }
        public DbSet<Participation> Participations { get; set; }



    }


}
