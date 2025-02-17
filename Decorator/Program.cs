using Decorator;

var azure = new AzureNewsletterSender();
var database = new NewsletterDatabaseDecorator(azure);
var stats = new NewsletterStatisticsDecorator(database);

await stats.SendNewsletter("Ma newsletter 1");
await stats.SendNewsletter("Ma newsletter 2");
Console.WriteLine($"Nb newsletters envoyées : {NewsletterStatisticsDecorator.NbNewsletterSent}");