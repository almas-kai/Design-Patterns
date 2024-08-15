class ForwardMovementCommand : IMovementCommand
{
    public ReceiverRobot ReceiverRobot { get; set; }
    public ForwardMovementCommand(ReceiverRobot receiver)
    {
        ReceiverRobot = receiver;
    }
    public void Execute()
    {
        ReceiverRobot.MoveForward();
    }
    public void Undo()
    {
        ReceiverRobot.MoveBackwards();
    }
}