namespace Mediator;

class Program
{
    static void Main()
    {
        Player player = new Player();
        GameMediator mediator = new GameMediator(player);

        LeftArrowButton left = new LeftArrowButton(mediator);
        RightArrowButton right = new RightArrowButton(mediator);
        UpArrowButton up = new UpArrowButton(mediator);
        DownArrowButton down = new DownArrowButton(mediator);

        left.Press();
        right.Press();
        up.Press();
        down.Press();
    }
}
