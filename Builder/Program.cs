using Builder;

var borne = new BorneDeVente();

var reineBuilder = new ReineBuilder();
borne.PreparerPizza(reineBuilder);
Console.WriteLine(reineBuilder.Pizza);

var chevreMielBuilder = new ChevreMielBuilder();
borne.PreparerPizza(chevreMielBuilder);
Console.WriteLine(chevreMielBuilder.Pizza);