using Command;

var manager = new CommandManager();

var magasin = new Magasin();
var commande = new AcheterArticle(magasin, new Article("Tournevis"));

manager.ExecuteCommand(commande);
var tournevisQte = magasin.Stock.First(s => s.Article.Nom == "Tournevis").Quantite;
Console.WriteLine($"Il reste {tournevisQte} tournevis");

manager.ExecuteCommand(commande);
tournevisQte = magasin.Stock.First(s => s.Article.Nom == "Tournevis").Quantite;
Console.WriteLine($"Il reste {tournevisQte} tournevis");

manager.ExecuteCommand(commande);
tournevisQte = magasin.Stock.First(s => s.Article.Nom == "Tournevis").Quantite;
Console.WriteLine($"Il reste {tournevisQte} tournevis");