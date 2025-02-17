namespace Facade
{
    public class PersonneFacade(PersonneService personneService, AddressService addressService, CommandeService commandeService)
    {
        public PersonneAvecAddresseEtCommande? GetInfos(int id)
        {
            if (id == 1)
            {
                var personne = personneService.GetPersonne(id);
                if (personne is not null)
                {
                    var address = addressService.GetAddress(personne.AddressLongitude, personne.AddressLatitude);
                    var commandes = commandeService.GetCommande(id);
                    return new()
                    {
                        Id = id,
                        Nom = personne.Nom,
                        Prenom = personne.Prenom,
                        CodePostal = address?.CodePostal ?? "9999",
                        Pays = address?.Pays ?? "France",
                        Rue = address?.Rue ?? "Rue inconnue",
                        Commandes = commandes
                    };
                }
            }
            return null;
        }
    }
}