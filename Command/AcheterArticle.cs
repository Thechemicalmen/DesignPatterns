namespace Command
{
    public class AcheterArticle(Magasin magasin, Article article) : ICommand
    {
        public bool CanExecute() => magasin.EstEnStock(article);
        public void Execute() => magasin.Acheter(article);
    }
}