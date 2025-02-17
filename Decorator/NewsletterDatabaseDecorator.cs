namespace Decorator
{
    public class NewsletterDatabaseDecorator : NewsletterSenderDecorator
    {
        public NewsletterDatabaseDecorator(INewsletterSender sender) : base(sender)
        {

        }

        public override Task<bool> SendNewsletter(string content)
        {
            Console.WriteLine($"Sauvegarde en BDD du contenu : {content}");
            return base.SendNewsletter(content);
        }
    }
}