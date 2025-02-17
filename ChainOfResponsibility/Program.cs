using ChainOfResponsibility;

var commandeValide = new AcheterArticle(1, "5555-5555-5555-5555");
var commandeInvalide = new AcheterArticle(2, "123");

Func<string, bool> valideCarte = (s) => s.Length == 19;

var handlers = new VerifierStockHandler().SetSuccessor(new VerifierCarteBancaire(valideCarte));

try
{
    await handlers.HandleAsync(commandeValide);
    Console.WriteLine("Commande valide pour l'article 1");
    await handlers.HandleAsync(commandeInvalide);
    Console.WriteLine("Commande valide pour l'article 2");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}