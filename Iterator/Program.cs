using Iterator;

var p = new PersonneCollection()
{
    new Personne() { Nom = "Alice" },
    new Personne() { Nom = "Charles" },
    new Personne() { Nom = "Bob" },
    new Personne() { Nom = "Adam" },
    new Personne() { Nom = "Obiwan" }
};

var iterator = p.GetIterator();

while (iterator.MoveNext())
    Console.WriteLine(iterator.Current?.Nom);