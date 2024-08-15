class LeftMovementCommand : IMovementCommand
{
    public ReceiverRobot ReceiverRobot { get; set; }
    public LeftMovementCommand(ReceiverRobot receiver)
    {
        ReceiverRobot = receiver;
    }
    public void Execute()
    {
        ReceiverRobot.TurnLeft();
    }
    public void Undo()
    {
        ReceiverRobot.TurnRight();
    }
}