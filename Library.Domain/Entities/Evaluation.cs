using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Entities
{
    public class Evaluation
    {
        public int Id { get; set; }

        public int LivreId { get; set; }
        public Livre Livre { get; set; }

        public int UsagerId { get; set; }
        public Usager Usager { get; set; }

        public int Note { get; set; } // 1 à 5
        public string Commentaire { get; set; }

        public DateTime DateEvaluation { get; set; }
    }

}
