namespace Command
{
    public class Magasin
    {
        private List<ArticleStock> _stock;
        public IEnumerable<ArticleStock> Stock => _stock.AsEnumerable();

        public Magasin()
        {
            _stock = [
                new ArticleStock(){Article = new("Tournevis"), Quantite = 2 },
                new ArticleStock(){Article = new("Marteau"), Quantite = 1 }
                ];
        }

        public bool EstEnStock(Article article) => _stock.Find(a => a.Article == article)?.Quantite > 0;

        public void Acheter(Article article)
        {
            var elementStock = _stock.Find(a => a.Article == article);
            if (elementStock is not null && elementStock.Quantite > 0)
                elementStock.Quantite--;
        }
    }
}