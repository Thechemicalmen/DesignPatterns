namespace Observer
{
    public interface IArticlePriceObserver
    {
        void ReceivePriceChanged(object sender, ArticlePriceUpdated info);
    }
}