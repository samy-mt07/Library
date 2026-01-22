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
        public string Nom { get; set; } = string.Empty;
        public int QuantiteTotale { get; set; }
        public bool Actif { get; set; } = true;
        public ICollection<EmpruntMateriel> Emprunts { get; set; }
        }

    
}
