using Library.Domain.Entities;
using Library.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Library.Application.Services
{
    public class UsagerService
    {
        private readonly DbFactory _factory;

        public UsagerService(DbFactory factory)
        {
            _factory = factory;
        }

        // 👥 Tous les usagers
        public async Task<List<Usager>> GetAllAsync()
        {
            using var db = _factory.Create();
            return await db.Usagers
                .OrderBy(u => u.NomComplet)
                .ToListAsync();
        }

        // ✅ Usagers actifs seulement
        public async Task<List<Usager>> GetActifsAsync()
        {
            using var db = _factory.Create();

            return await db.Usagers
                .Where(u => u.Actif)
                .OrderBy(u => u.NomComplet)
                .ToListAsync();
        }

        // ➕ Ajouter un usager
        public async Task AjouterAsync(string nomComplet, string email, string telephone)
        {
            if (string.IsNullOrWhiteSpace(nomComplet))
                throw new Exception("Le nom complet est obligatoire.");

            if (string.IsNullOrWhiteSpace(email))
                throw new Exception("L'email est obligatoire.");

            var usager = new Usager
            {
                NomComplet = nomComplet.Trim(),
                Email = email.Trim(),
                Telephone = telephone.Trim(),
                Actif = true
            };
            using var db = _factory.Create();
            db.Usagers.Add(usager);
            await db.SaveChangesAsync();
        }

        // ❌ Désactiver un usager (historique conservé)
        public async Task DesactiverAsync(int usagerId)
        {
            using var db = _factory.Create();

            var usager = await db.Usagers.FindAsync(usagerId);

            if (usager == null)
                throw new Exception("Usager introuvable.");
         
            usager.Actif = false;
            await db.SaveChangesAsync();
        }

        // 📊 Historique des emprunts d’un usager
        public async Task<List<Emprunt>> GetHistoriqueEmpruntsAsync(int usagerId)
        {
            using var db = _factory.Create();
            return await db.Emprunts
                .Include(e => e.Livre)
                .Where(e => e.UsagerId == usagerId)
                .OrderByDescending(e => e.DateEmprunt)
                .ToListAsync();
        }
    }
}
