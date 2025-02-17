using Bridge;

var pasDeReduc = new PasDeReduction();
var reducFaible = new ReductionFaible();
var reducForte = new ReductionForte();

var abonnement = new AbonnementStandard(null);
Console.WriteLine($"Prix : {abonnement.GetPrice()}");

var abonnementP = new AbonnementPremium(pasDeReduc);
Console.WriteLine($"Prix : {abonnementP.GetPrice()}");

var abonnementS = new AbonnementStandard(reducFaible);
Console.WriteLine($"Prix : {abonnementS.GetPrice()}");

var abonnementBF = new AbonnementPremium(reducForte);
Console.WriteLine($"Prix : {abonnementBF.GetPrice()}");