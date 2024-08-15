class BackwardsMovementCommand : IMovementCommand
{
    public ReceiverRobot ReceiverRobot { get; set; }
    public BackwardsMovementCommand(ReceiverRobot receiver)
    {
        ReceiverRobot = receiver;
    }
    public void Execute()
    {
        ReceiverRobot.MoveBackwards();
    }
    public void Undo()
    {
        ReceiverRobot.MoveForward();
    }
}