namespace ChainOfResponsibility
{
    public interface IHandler<T> where T : class
    {
        IHandler<T> SetSuccessor(IHandler<T> handler);
        Task HandleAsync(T request);
    }

    public record AcheterArticle(int Id, string NumeroCarte);

    public abstract class BaseHandler<T> : IHandler<T> where T : class
    {
        protected IHandler<T>? _successor;

        public abstract Task HandleAsync(T request);
        public IHandler<T> SetSuccessor(IHandler<T> handler)
        {
            _successor = handler;
            return _successor;
        }
    }

    public class VerifierStockHandler(int stockInitial = 1) : BaseHandler<AcheterArticle>
    {
        public override Task HandleAsync(AcheterArticle request)
        {
            if (stockInitial <= 0)
                throw new InvalidOperationException("Pas assez de stock");

            if(_successor is not null)
                return _successor.HandleAsync(request);

            return Task.CompletedTask;
        }
    }

    public class VerifierCarteBancaire(Func<string, bool> verifCarte) : BaseHandler<AcheterArticle>
    {
        public override Task HandleAsync(AcheterArticle request)
        {
            if (!verifCarte(request.NumeroCarte))
                throw new InvalidOperationException("Carte invalide");

            if(_successor is not null)
                return _successor.HandleAsync(request);

            return Task.CompletedTask;
        }
    }
}