namespace Decorator
{
    public abstract class NewsletterSenderDecorator(INewsletterSender sender) : INewsletterSender
    {
        public virtual Task<bool> SendNewsletter(string content)
        {
            return sender.SendNewsletter(content);
        }
    }
}