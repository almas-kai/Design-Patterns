namespace CQRS;

internal interface ICommandHandler<TCommand>
	where TCommand : ICommand
{
	public void Handle(TCommand command);
}

internal interface ICommandHandler<TCommand, TResult>
	where TCommand : ICommand<TResult>
{
	public TResult Handle(TCommand command);
}