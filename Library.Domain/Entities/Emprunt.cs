using System;

namespace Library.Domain.Entities
{
    public class Emprunt
    {
        public int Id { get; set; }

        public DateTime DateEmprunt { get; set; } = DateTime.Now;
        public DateTime DateRetourPrevue { get; set; }
        public DateTime? DateRetourReelle { get; set; }

        public EtatEmprunt Etat { get; set; } = EtatEmprunt.EnCours;

        // FK
        public int UsagerId { get; set; }
        public Usager Usager { get; set; } = null!;

        public int LivreId { get; set; }
        public Livre Livre { get; set; } = null!;
    }
}
