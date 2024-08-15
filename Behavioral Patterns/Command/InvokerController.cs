class InvokerController
{
    private readonly Stack<IMovementCommand> _Commands = new Stack<IMovementCommand>();
    public void ExecuteCommand(IMovementCommand command)
    {
        _Commands.Push(command);
        command.Execute();
    }
    public void UndoLastCommand()
    {
        if (_Commands.Count > 0)
        {
            _Commands.Pop().Undo();
        }
    }
    public void UndoAllCommands()
    {
        while (_Commands.Count > 0)
        {
            _Commands.Pop().Undo();
        }
    }
}