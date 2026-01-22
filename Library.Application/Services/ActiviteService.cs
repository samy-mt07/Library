using Library.Domain.Entities;
<<<<<<< HEAD
using Library.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

=======
using Microsoft.EntityFrameworkCore;
using Library.Infrastructure.Data;
>>>>>>> e80ee4aa827c85436f43b3d8139a9c038cd52199
namespace Library.Application.Services
{
    public class ActiviteService
    {
<<<<<<< HEAD
        private readonly DbFactory _factory;

        public ActiviteService(DbFactory factory)
        {
            _factory = factory;
        }

        // ✅ 1) Liste des activités (pour remplir cboActivite)
        public async Task<List<Activite>> GetAllAsync()
        {
            using var db = _factory.Create();

            return await db.Activites
                .OrderBy(a => a.Titre)
                .ToListAsync();
        }

        // ✅ 2) Créer une activité (pour btnCreerActivite)
        public async Task CreerAsync(string titre, TypeActivite type, int capaciteMax)
        {
            using var db = _factory.Create();

            titre = (titre ?? "").Trim();
            if (titre.Length < 3)
                throw new Exception("Le titre de l'activité doit contenir au moins 3 caractères.");

            if (capaciteMax <= 0)
                throw new Exception("La capacité maximale doit être supérieure à 0.");

            var activite = new Activite
            {
                Titre = titre,
                Type = type,
                CapaciteMax = capaciteMax,
                DateDebut = null,
                DateFin = null
            };

            db.Activites.Add(activite);
            await db.SaveChangesAsync();
        }

        // ✅ 3) Inscrire un usager (pour btnInscrire)
        // -> même logique que ton InscrireUsagerAsync, mais nom adapté au Form
        public async Task InscrireAsync(int usagerId, int activiteId)
        {
            using var db = _factory.Create();

            var activite = await db.Activites.FirstOrDefaultAsync(a => a.Id == activiteId);
            if (activite == null)
                throw new Exception("Activité introuvable.");

            var usager = await db.Usagers.FirstOrDefaultAsync(u => u.Id == usagerId);
            if (usager == null)
                throw new Exception("Usager introuvable.");

            if (!usager.Actif)
                throw new Exception("Cet usager est inactif.");

            // 1) pas de doublon
            bool existe = await db.Participations
                .AnyAsync(p => p.UsagerId == usagerId && p.ActiviteId == activiteId);

            if (existe)
                throw new Exception("L'usager est déjà inscrit à cette activité.");

            // 2) capacité max
            int count = await db.Participations.CountAsync(p => p.ActiviteId == activiteId);
            if (count >= activite.CapaciteMax)
                throw new Exception("Capacité maximale atteinte.");

            // 3) inscrire
            db.Participations.Add(new Participation
=======
        private readonly BibliothequeDbContext _db;

        public ActiviteService(BibliothequeDbContext db)
        {
            _db = db;
        }

        public async Task InscrireUsagerAsync(int usagerId, int activiteId)
        {
            var activite = await _db.Activites.FirstOrDefaultAsync(a => a.Id == activiteId);
            if (activite == null) throw new Exception("Activité introuvable.");

            // 1) pas de doublon
            bool existe = await _db.Participations.AnyAsync(p => p.UsagerId == usagerId && p.ActiviteId == activiteId);
            if (existe) throw new Exception("L'usager est déjà inscrit à cette activité.");

            // 2) capacité max
            int count = await _db.Participations.CountAsync(p => p.ActiviteId == activiteId);
            if (count >= activite.CapaciteMax) throw new Exception("Capacité maximale atteinte.");

            // 3) inscrire
            _db.Participations.Add(new Participation
>>>>>>> e80ee4aa827c85436f43b3d8139a9c038cd52199
            {
                UsagerId = usagerId,
                ActiviteId = activiteId,
                DateInscription = DateTime.Now,
                Presence = null
            });

<<<<<<< HEAD
            await db.SaveChangesAsync();
        }

        // ✅ 4) Récupérer les participations (pour dgvParticipations)
        public async Task<List<Participation>> GetParticipationsAsync()
        {
            using var db = _factory.Create();

            return await db.Participations
                .Include(p => p.Usager)
                .Include(p => p.Activite)
                .OrderByDescending(p => p.DateInscription)
                .ToListAsync();
=======
            await _db.SaveChangesAsync();
>>>>>>> e80ee4aa827c85436f43b3d8139a9c038cd52199
        }
    }
}
