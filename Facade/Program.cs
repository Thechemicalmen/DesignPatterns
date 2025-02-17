using Facade;

var service = new PersonneFacade(new(), new(), new());

var personne1 = service.GetInfos(1);

if (personne1 is not null)
    Console.WriteLine($"{personne1.Nom} {personne1.Prenom} : {personne1.CodePostal} avec {personne1.Commandes.Count()} commande(s)");

var personne2 = service.GetInfos(2);

if (personne2 is null)
    Console.WriteLine("personne2 est null");