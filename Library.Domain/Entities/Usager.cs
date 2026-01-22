using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Entities
{
    public class Usager
    {

         public int Id { get; set; }

        public string NomComplet { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Telephone { get; set; } = string.Empty;

        public bool Actif { get; set; } = true;
<<<<<<< HEAD
        public ICollection<Emprunt> Emprunts { get; set; } = new List<Emprunt>();
=======
        public List<Emprunt> Emprunts { get; set; } = new();
>>>>>>> e80ee4aa827c85436f43b3d8139a9c038cd52199
        public List<Participation> Participations { get; set; } = new();

    }


}
