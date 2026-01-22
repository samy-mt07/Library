using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Entities
{
    
        public class Materiel
        {
            public int Id { get; set; }
            public string Nom { get; set; }
            public string Etat { get; set; } // Disponible, En maintenance
            public int Quantite { get; set; }

            public ICollection<EmpruntMateriel> Emprunts { get; set; }
        }

    
}
