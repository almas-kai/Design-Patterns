namespace Command;

class Program
{
    static void Main()
    {
        ReceiverRobot myRobot = new ReceiverRobot("Super Bot");
        InvokerController controller = new InvokerController();

        IMovementCommand forwardCommand = new ForwardMovementCommand(myRobot);
        IMovementCommand backwardsCommand = new BackwardsMovementCommand(myRobot);
        IMovementCommand turnLeftCommand = new LeftMovementCommand(myRobot);
        IMovementCommand turnRightCommand = new RightMovementCommand(myRobot);

        controller.ExecuteCommand(forwardCommand);
        controller.ExecuteCommand(turnLeftCommand);
        controller.ExecuteCommand(forwardCommand);
        controller.ExecuteCommand(turnRightCommand);
        controller.ExecuteCommand(backwardsCommand);

        controller.UndoAllCommands();
    }
}
