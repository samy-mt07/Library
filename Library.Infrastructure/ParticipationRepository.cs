using Library.Domain.Entities;
using Library.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Library.Infrastructure.Repositories
{
    public class ParticipationRepository
    {
        private readonly BibliothequeDbContext _db;

        public ParticipationRepository(BibliothequeDbContext db)
        {
            _db = db;
        }

        public async Task<bool> ExisteAsync(int usagerId, int activiteId)
        {
            return await _db.Participations
                .AnyAsync(p => p.UsagerId == usagerId && p.ActiviteId == activiteId);
        }

        public async Task<int> CompterParticipantsAsync(int activiteId)
        {
            return await _db.Participations.CountAsync(p => p.ActiviteId == activiteId);
        }

        public async Task AjouterAsync(Participation participation)
        {
            _db.Participations.Add(participation);
            await _db.SaveChangesAsync();
        }
    }
}
