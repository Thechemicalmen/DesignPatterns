namespace Decorator
{
    public interface INewsletterSender
    {
        Task<bool> SendNewsletter(string content);
    }
}