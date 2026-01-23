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
  

    public class MaterielService
    {
        private readonly BibliothequeDbContext _db;

        public MaterielService(BibliothequeDbContext db)
        {
            _db = db;
        }

        public async Task EmprunterMaterielAsync(int materielId, int usagerId)
        {
            var materiel = await _db.Materiels.FindAsync(materielId);
            if (materiel == null || materiel.QuantiteTotale <= 0)
                throw new Exception("Matériel non disponible.");

            var emprunt = new EmpruntMateriel
            {
                MaterielId = materielId,
                UsagerId = usagerId,
                DateEmprunt = DateTime.Now,
                DateRetour = DateTime.Now.AddDays(7)
            };

            materiel.QuantiteTotale--;

            _db.EmpruntsMateriel.Add(emprunt);
            await _db.SaveChangesAsync();
        }

        public async Task RetournerMaterielAsync(int empruntMaterielId)
        {
            var emprunt = await _db.EmpruntsMateriel
                .Include(e => e.Materiel)
                .FirstOrDefaultAsync(e => e.Id == empruntMaterielId);

            if (emprunt == null)
                throw new Exception("Emprunt introuvable.");

            emprunt.DateRetour = DateTime.Now;
            emprunt.Materiel.QuantiteTotale++;

            await _db.SaveChangesAsync();
        }

        public async Task<List<EmpruntMateriel>> GetHistoriqueParUsagerAsync(int usagerId)
        {
            return await _db.EmpruntsMateriel
                .Include(e => e.Materiel)
                .Where(e => e.UsagerId == usagerId)
                .ToListAsync();
        }
        public async Task<List<Materiel>> GetAllMaterielsAsync()
        {
            return await _db.Materiels
                .OrderBy(m => m.Nom)
                .ToListAsync();
        }

        public async Task<List<Materiel>> GetMaterielsDisponiblesAsync()
        {
            return await _db.Materiels
                .Where(m => m.Actif && m.QuantiteTotale > 0)
                .OrderBy(m => m.Nom)
                .ToListAsync();
        }

        public async Task AjouterMaterielAsync(string nom, int quantite)
        {
            if (string.IsNullOrWhiteSpace(nom))
                throw new Exception("Nom obligatoire.");
            if (quantite <= 0)
                throw new Exception("Quantité invalide.");

            _db.Materiels.Add(new Materiel
            {
                Nom = nom.Trim(),
                QuantiteTotale = quantite,
                Actif = true
            });

            await _db.SaveChangesAsync();
        }

    }

}
