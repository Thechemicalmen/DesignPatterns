namespace Decorator
{
    public class NewsletterStatisticsDecorator : NewsletterSenderDecorator
    {
        public static int NbNewsletterSent = 0;

        public NewsletterStatisticsDecorator(INewsletterSender sender) : base(sender)
        {

        }

        public override Task<bool> SendNewsletter(string content)
        {
            NbNewsletterSent++;
            return base.SendNewsletter(content);
        }
    }
}