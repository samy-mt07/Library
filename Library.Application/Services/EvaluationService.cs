using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Services
{
    using Library.Domain.Entities;
    using Library.Infrastructure.Data;
    using Microsoft.EntityFrameworkCore;

    public class EvaluationService
    {
        private readonly BibliothequeDbContext _db;

        public EvaluationService(BibliothequeDbContext db)
        {
            _db = db;
        }

        public async Task AjouterEvaluationAsync(int livreId, int usagerId, int note, string commentaire)
        {
            if (note < 1 || note > 5)
                throw new Exception("La note doit être entre 1 et 5.");

            bool existe = await _db.Evaluations
                .AnyAsync(e => e.LivreId == livreId && e.UsagerId == usagerId);

            if (existe)
                throw new Exception("Évaluation déjà existante.");

            var evaluation = new Evaluation
            {
                LivreId = livreId,
                UsagerId = usagerId,
                Note = note,
                Commentaire = commentaire,
                DateEvaluation = DateTime.Now
            };

            _db.Evaluations.Add(evaluation);
            await _db.SaveChangesAsync();
        }

        public async Task<double> GetMoyenneLivreAsync(int livreId)
        {
            return await _db.Evaluations
                .Where(e => e.LivreId == livreId)
                .AverageAsync(e => (double?)e.Note) ?? 0;
        }

        public async Task<List<Evaluation>> GetEvaluationsParLivreAsync(int livreId)
        {
            return await _db.Evaluations
                .Include(e => e.Usager)
                .Where(e => e.LivreId == livreId)
                .ToListAsync();
        }
    }

}
