namespace Observer
{
    public abstract class AbstractArticlePriceNotifier
    {
        //private List<IArticlePriceObserver> _observers = [];
        public event EventHandler<ArticlePriceUpdated>? ArticlePriceUpdated;

        /*public void AddObserver(IArticlePriceObserver observer) => _observers.Add(observer);

        public void RemoveObserver(IArticlePriceObserver observer) => _observers.Remove(observer);*/

        public void Notify(ArticlePriceUpdated info)
        {
            /*foreach (var observer in _observers)
                observer.ReceivePriceChanged(info);*/
            ArticlePriceUpdated?.Invoke(this, info);
        }
    }
}