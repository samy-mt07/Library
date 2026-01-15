namespace Library.Domain.Entities
{
    public class Livre
    {
        public int Id { get; set; }

        public string Titre { get; set; } = string.Empty;
        public string Isbn { get; set; } = string.Empty;
        public int QuantiteTotale { get; set; }
        public bool Actif { get; set; } = true;
        public List<Emprunt> Emprunts { get; set; } = new();

    }
}
