class ReceiverRobot
{
    public string Name { get; set; }
    public ReceiverRobot(string name)
    {
        Name = name;
    }
    public void MoveForward()
    {
        Console.WriteLine($"{Name} is moving forward.");
    }
    public void MoveBackwards()
    {
        Console.WriteLine($"{Name} is moving backwards.");
    }
    public void TurnLeft()
    {
        Console.WriteLine($"{Name} is turning left.");
    }
    public void TurnRight()
    {
        Console.WriteLine($"{Name} is turning right.");
    }
}