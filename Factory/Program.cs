using Factory;
using Factory.Factories;

Patient a = new();
Patient b = new() { NumeroMutuelle = "00345112521" };
Patient c = new() { NumeroMutuelle = "00531245612" };

var factory = new LesOisillionsMutuelleFactory();

Console.WriteLine($"Patient a = {factory.GetMutuelle(a).GetPourcentageRemboursementMedecinTraitant()}");
Console.WriteLine($"Patient b = {factory.GetMutuelle(b).GetPourcentageRemboursementMedecinTraitant()}");
Console.WriteLine($"Patient c = {factory.GetMutuelle(c).GetPourcentageRemboursementMedecinTraitant()}");