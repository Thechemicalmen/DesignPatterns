using Adapter;

var adapter = new PersonAdapter(new ExternalPersonAPIService());
var adapter2 = new ExternalPersonAdapter();

var person1 = adapter.GetPerson();
Console.WriteLine($"{person1.ID}. {person1.Name} {person1.LastName}");

var person2 = adapter2.GetPerson();
Console.WriteLine($"{person2.ID}. {person2.Name} {person2.LastName}");