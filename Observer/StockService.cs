namespace Observer
{
    public class StockService : AbstractArticlePriceNotifier
    {
        public void AddItemInStock(int articleId, decimal price) => Notify(new ArticlePriceUpdated(articleId, 0, price));
    }
}