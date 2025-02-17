namespace Command
{
    public class CommandManager
    {
        public void ExecuteCommand(ICommand command)
        {
            if(command.CanExecute())
                command.Execute();
        }
    }
}