using System;

namespace Library.Domain.Entities
{
    public class Participation
    {
        // PK composite (UsagerId + ActiviteId) sera configurée dans DbContext
        public int UsagerId { get; set; }
        public Usager Usager { get; set; } = null!;

        public int ActiviteId { get; set; }
        public Activite Activite { get; set; } = null!;

        public DateTime DateInscription { get; set; } = DateTime.Now;
        public bool? Presence { get; set; }
    }
}
