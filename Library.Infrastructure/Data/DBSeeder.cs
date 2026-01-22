using Library.Domain.Entities;

namespace Library.Infrastructure.Data
{
    public static class DbSeeder
    {
        public static void SeedIfEmpty(BibliothequeDbContext db)
        {
            // Si déjà des usagers/livres → on ne seed pas
            if (db.Usagers.Any() || db.Livres.Any() || db.Activites.Any())
                return;

            // ✅ USAGERS
            db.Usagers.AddRange(
                new Usager { NomComplet = "Samy Aissi", Email = "samy@test.com", Telephone = "514-000-0000", Actif = true },
                new Usager { NomComplet = "Nora Test", Email = "nora@test.com", Telephone = "514-111-1111", Actif = true },
                new Usager { NomComplet = "Ali Test", Email = "ali@test.com", Telephone = "514-222-2222", Actif = true }
            );

            // ✅ LIVRES
            db.Livres.AddRange(
                new Livre { Titre = "C# Avancé", Isbn = "ISBN-001", QuantiteTotale = 5, Actif = true },
                new Livre { Titre = "SQL Server Débutant", Isbn = "ISBN-002", QuantiteTotale = 3, Actif = true },
                new Livre { Titre = "Design Patterns", Isbn = "ISBN-003", QuantiteTotale = 2, Actif = true }
            );

            // ✅ ACTIVITÉS (TypeActivite: 0/1 selon ton enum)
            db.Activites.AddRange(
                new Activite { Titre = "Atelier C#", Type = TypeActivite.Evenement, CapaciteMax = 10 },
                new Activite { Titre = "Concours Lecture", Type = TypeActivite.Concours, CapaciteMax = 5 }
            );

            // ✅ MATÉRIEL (si tu l’utilises)
            db.Materiels.AddRange(
                new Materiel { Nom = "Tablette", QuantiteTotale = 2, Actif = true },
                new Materiel { Nom = "Projecteur", QuantiteTotale = 1, Actif = true }
            );

            db.SaveChanges();
        }
    }
}
