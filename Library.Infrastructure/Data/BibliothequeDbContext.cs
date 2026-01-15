using Library.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library.Infrastructure.Data
{
    public class BibliothequeDbContext : DbContext
    {
        public BibliothequeDbContext(DbContextOptions<BibliothequeDbContext> options)
            : base(options)
        {
        }

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

}
