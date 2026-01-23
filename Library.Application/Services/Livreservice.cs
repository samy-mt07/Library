using Library.Domain.Entities;
using Library.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;        // ✅ OBLIGATOIRE
using System.Threading.Tasks;



namespace Library.Application.Services
{
    public class LivreService
    {
        private readonly DbFactory _factory;

        public LivreService(DbFactory factory)
        {
            _factory = factory;
        }

        // 📚 Tous les livres
        public async Task<List<Livre>> GetAllAsync()
        {
            using var db = _factory.Create();

            return await db.Livres
                .OrderBy(l => l.Titre)
                .ToListAsync();
        }

        // 📗 Livres actifs seulement
        public async Task<List<Livre>> GetActifsAsync()
        {
            using var db = _factory.Create();

            return await db.Livres
                .Where(l => l.Actif)
                .OrderBy(l => l.Titre)
                .ToListAsync();
        }

        // 📕 Livres disponibles (quantité restante > emprunts actifs)
        public async Task<List<Livre>> GetDisponiblesAsync()
        {
            using var db = _factory.Create();

            // 🔥 Version correcte 100% async (sans Count sync)
            return await db.Livres
                .Where(l => l.Actif)
                .Where(l =>
                    l.QuantiteTotale >
                    db.Emprunts.Count(e => e.LivreId == l.Id && e.Etat == EtatEmprunt.EnCours)
                )
                .OrderBy(l => l.Titre)
                .ToListAsync();
        }

        // ➕ Ajouter un livre
        public async Task AjouterAsync(string titre, string isbn, int quantite)
        {
            using var db = _factory.Create();

            if (string.IsNullOrWhiteSpace(titre))
                throw new Exception("Le titre est obligatoire.");

            if (quantite <= 0)
                throw new Exception("La quantité doit être > 0.");

            var livre = new Livre
            {
                Titre = titre.Trim(),
                Isbn = (isbn ?? "").Trim(),
                QuantiteTotale = quantite,
                Actif = true
            };

            db.Livres.Add(livre);
            await db.SaveChangesAsync();
        }

        // ❌ Désactiver un livre (historique conservé)
        public async Task DesactiverAsync(int livreId)
        {
            using var db = _factory.Create();

            var livre = await db.Livres.FindAsync(livreId);
            if (livre == null)
                throw new Exception("Livre introuvable.");

            livre.Actif = false;
            await db.SaveChangesAsync();
        }
    }
}
