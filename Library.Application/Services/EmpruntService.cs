using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Domain.Entities;
using Library.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Library.Application.Services
{
    

    public class EmpruntService
    {
        private readonly BibliothequeDbContext _db;

        public EmpruntService(BibliothequeDbContext db)
        {
            _db = db;
        }

        public async Task EmprunterLivreAsync(int livreId, int usagerId)
        {
            var livre = await _db.Livre.FindAsync(livreId);
            if (livre == null || livre.QuantiteTotale <= 0)
                throw new Exception("Livre non disponible.");

            var emprunt = new Emprunt
            {
                LivreId = livreId,
                UsagerId = usagerId,
                DateEmprunt = DateTime.Now,
                DateRetourPrevue = DateTime.Now.AddDays(14),
                Etat = EtatEmprunt.EnCours
            };

            livre.QuantiteTotale--;

            _db.Emprunts.Add(emprunt);
            await _db.SaveChangesAsync();
        }

        public async Task RetournerLivreAsync(int empruntId)
        {
            var emprunt = await _db.Emprunts
                .Include(e => e.Livre)
                .FirstOrDefaultAsync(e => e.Id == empruntId);

            if (emprunt == null)
                throw new Exception("Emprunt introuvable.");

            emprunt.DateRetourPrevue = DateTime.Now;
            emprunt.Etat = emprunt.DateRetourPrevue > emprunt.DateRetourPrevue
                ? EtatEmprunt.EnRetard
                : EtatEmprunt.Retourne;

            emprunt.Livre.QuantiteTotale++;

            await _db.SaveChangesAsync();
        }

        public async Task<List<Emprunt>> GetEmpruntsParUsagerAsync(int usagerId)
        {
            return await _db.Emprunts
                .Include(e => e.Livre)
                .Where(e => e.UsagerId == usagerId)
                .ToListAsync();
        }
    }

}
