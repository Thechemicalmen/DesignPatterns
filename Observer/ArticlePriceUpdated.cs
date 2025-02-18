namespace Observer
{
    public record ArticlePriceUpdated(int ArticleId, decimal OldPrice, decimal NewPrice);
}