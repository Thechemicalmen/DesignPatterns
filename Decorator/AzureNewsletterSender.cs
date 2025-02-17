namespace Decorator
{
    public class AzureNewsletterSender : INewsletterSender
    {
        public Task<bool> SendNewsletter(string content)
        {
            Console.WriteLine("Newsletter envoyée avec succès depuis Azure !");
            return Task.FromResult(true);
        }
    }
}