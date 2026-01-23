using Library.Domain.Entities;
using Library.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Library.Application.Services
{
    public class EmpruntService
    {
        private readonly DbFactory _factory;

        public EmpruntService(DbFactory factory)
        {
            _factory = factory;
        }

    
        public async Task CreerEmpruntAsync(int usagerId, int livreId, DateTime retourPrevu)
        {
            using var db = _factory.Create();

            var livre = await db.Livres.FindAsync(livreId);
            if (livre == null || !livre.Actif)
                throw new Exception("Livre introuvable ou inactif.");

            var usager = await db.Usagers.FindAsync(usagerId);
            if (usager == null || !usager.Actif)
                throw new Exception("Usager introuvable ou inactif.");

            // dispo = QuantiteTotale - emprunts en cours
            int empruntsEnCours = await db.Emprunts
                .CountAsync(e => e.LivreId == livreId && e.Etat == EtatEmprunt.EnCours);

            if (livre.QuantiteTotale - empruntsEnCours <= 0)
                throw new Exception("Livre non disponible (plus d'exemplaires).");

            if (retourPrevu.Date <= DateTime.Now.Date)
                throw new Exception("La date de retour prévue doit être dans le futur.");

            var emprunt = new Emprunt
            {
                LivreId = livreId,
                UsagerId = usagerId,
                DateEmprunt = DateTime.Now,
                DateRetourPrevue = retourPrevu,
                Etat = EtatEmprunt.EnCours
            };

            db.Emprunts.Add(emprunt);
            await db.SaveChangesAsync();
        }

        public async Task RetournerAsync(int empruntId)
        {
            using var db = _factory.Create();

            var emprunt = await db.Emprunts.FirstOrDefaultAsync(e => e.Id == empruntId);
            if (emprunt == null)
                throw new Exception("Emprunt introuvable.");

            if (emprunt.Etat == EtatEmprunt.Retourne)
                throw new Exception("Cet emprunt est déjà retourné.");

            emprunt.Etat = EtatEmprunt.Retourne;
            emprunt.DateRetourReelle = DateTime.Now;

            await db.SaveChangesAsync();
        }

        // (utile pour la grille)
        public async Task<List<Emprunt>> GetEmpruntsEnCoursAsync()
        {
            using var db = _factory.Create();

            return await db.Emprunts
                .Include(e => e.Usager)
                .Include(e => e.Livre)
                .Where(e => e.Etat == EtatEmprunt.EnCours)
                .OrderByDescending(e => e.DateEmprunt)
                .ToListAsync();
        }
        public async Task<List<Emprunt>> GetEmpruntsParUsagerAsync(int usagerId)
        {
            using var db = _factory.Create();

            return await db.Emprunts
                .Include(e => e.Livre)
                .Include(e => e.Usager)
                .Where(e => e.UsagerId == usagerId)
                .OrderByDescending(e => e.DateEmprunt)
                .ToListAsync();
        }
    }
}
