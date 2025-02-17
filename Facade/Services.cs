namespace Facade
{
    public record Personne(int Id, string Nom, string Prenom, int AddressLatitude, int AddressLongitude);

    public class PersonneService
    {
        public Personne GetPersonne(int id) => new(id, "VANDE MERT", "Florian", 9912, 31418);
    }

    public record Address(string Rue, string CodePostal, string Pays);

    public class AddressService
    {
        public Address GetAddress(int longitude, int latitude) => new("Rue Pierre Ouvrard, 1", "7880", "Belgique");
    }

    public record Commande(int Id, decimal Montant, DateTime Date);

    public class CommandeService
    {
        public IEnumerable<Commande> GetCommande(int personneId) => [new(1, 99.99m, DateTime.UtcNow),
                                                                     new(2, 520, DateTime.UtcNow.AddDays(-3)),
                                                                     new(3, 125m, DateTime.UtcNow.AddDays(-9))];
    }

    public class PersonneAvecAddresseEtCommande
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Rue { get; set; }
        public string CodePostal { get; set; }
        public string Pays { get; set; }
        public IEnumerable<Commande> Commandes { get; set; }
    }
}