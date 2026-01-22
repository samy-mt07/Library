using Library.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Library.Infrastructure.Data;
namespace Library.Application.Services
{
    public class ActiviteService
    {
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
            {
                UsagerId = usagerId,
                ActiviteId = activiteId,
                DateInscription = DateTime.Now,
                Presence = null
            });

            await _db.SaveChangesAsync();
        }
    }
}
