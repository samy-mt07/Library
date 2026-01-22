using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Entities
{
    
        public class EmpruntMateriel
        {
            public int Id { get; set; }

            public int MaterielId { get; set; }
            public Materiel Materiel { get; set; }

            public int UsagerId { get; set; }
            public Usager Usager { get; set; }

            public DateTime DateEmprunt { get; set; }
            public DateTime DateRetourPrevue { get; set; }
            public DateTime? DateRetour { get; set; }
        }

    
}
