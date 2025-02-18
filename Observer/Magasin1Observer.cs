namespace Observer
{
    public class Magasin1Observer : IArticlePriceObserver
    {
        public void ReceivePriceChanged(object sender, ArticlePriceUpdated info)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Nouveau prix pour {info.ArticleId} : {info.NewPrice} (ancien prix = {info.OldPrice})");
            Console.ResetColor();
        }
    }

    public class Magasin2Observer : IArticlePriceObserver
    {
        public void ReceivePriceChanged(object sender, ArticlePriceUpdated info)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Nouveau prix pour {info.ArticleId} : {info.NewPrice} (ancien prix = {info.OldPrice})");
            Console.ResetColor();
        }
    }
}