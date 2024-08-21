class GameMediator : IMediator
{
	private Player _Player { get; set; }
	public GameMediator(Player player)
	{
		_Player = player;
	}
	public void Notify(string pressedButton)
	{
		switch (pressedButton)
		{
			case "UpArrow":
				_Player.Up();
				break;
			case "RightArrow":
				_Player.Right();
				break;
			case "DownArrow":
				_Player.Down();
				break;
			case "LeftArrow":
				_Player.Left();
				break;
			default:
				Console.WriteLine("Unrecognized command.");
				break;
		}
	}
}