using Prototype;

var personne = new Personne("Florian");
Console.WriteLine($"Nom personne 1 {personne.Nom}");

var chien = new Chien("Fizz", personne);
Console.WriteLine($"Nom du chien 1 {chien.Nom}");
Console.WriteLine($"Nom du propietaire chien 1 {chien.Proprietaire.Nom}");

//var chienClone = (Chien)chien.Clone();
var chienClone = chien with { };
personne.Nom = "Oriane";
Console.WriteLine($"Nom du chien 2 {chienClone.Nom}");
Console.WriteLine($"Nom du propietaire chien 2 {chienClone.Proprietaire.Nom}");

Console.WriteLine($"Personne égales ? {object.ReferenceEquals(personne, chienClone.Proprietaire)}");