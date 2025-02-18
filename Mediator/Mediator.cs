namespace Mediator
{
    public interface ICommand { }
    public record AcheterArticle(string Article) : ICommand;

    public interface ICommandHandler<T> where T : ICommand
    {
        Task HandleAsync(T command);
    }

    public class AcheterArticleHandler : ICommandHandler<AcheterArticle>
    {
        public Task HandleAsync(AcheterArticle command)
        {
            Console.WriteLine($"Article acheté : {command.Article}");
            return Task.CompletedTask;
        }
    }

    public interface IMyMediator
    {
        void RegisterHandler<T>(ICommandHandler<T> handler) where T : ICommand;
        Task Handle<T>(T command) where T : ICommand;
    }

    public class MyMediator : IMyMediator
    {
        private Dictionary<Type, List<object>> handlers = [];

        public async Task Handle<T>(T command) where T : ICommand
        {
            if (handlers.TryGetValue(command.GetType(), out List<object>? localHandlers))
                foreach(var handler in localHandlers)
                    await ((ICommandHandler<T>)handler).HandleAsync(command);
        }
        public void RegisterHandler<T>(ICommandHandler<T> handler) where T : ICommand
        {
            var commandType = typeof(T);
            if (handlers.TryGetValue(commandType, out List<object>? value))
                value.Add(handler);
            else
                handlers.Add(commandType, [handler]);
        }
    }
}