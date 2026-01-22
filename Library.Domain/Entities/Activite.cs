using System;
using System.Collections.Generic;

namespace Library.Domain.Entities
{
    public class Activite
    {
        public int Id { get; set; }

        public string Titre { get; set; } = string.Empty;
        public string? Description { get; set; }

        public TypeActivite Type { get; set; } = TypeActivite.Evenement;

        public DateTime? DateDebut { get; set; }
        public DateTime? DateFin { get; set; }

        public int CapaciteMax { get; set; }

        // Navigation (N-N via Participation)
        public List<Participation> Participations { get; set; } = new();
    }
}
