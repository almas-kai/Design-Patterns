class RightMovementCommand : IMovementCommand
{
    public ReceiverRobot ReceiverRobot { get; set; }
    public RightMovementCommand(ReceiverRobot receiver)
    {
        ReceiverRobot = receiver;
    }
    public void Execute()
    {
        ReceiverRobot.TurnRight();
    }
    public void Undo()
    {
        ReceiverRobot.TurnLeft();
    }
}