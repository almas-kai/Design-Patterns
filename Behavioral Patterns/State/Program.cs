namespace State;

class Program
{
    static void Main()
    {
        RadioContext radioContext = new RadioContext();

        // Trying to turn off the radio that is already turned off.
        radioContext.TurnOff();

        // Trying to play some music on turned off radio.
        radioContext.PlayMusic();

        radioContext.TurnOn();

        // Playing some music.
        radioContext.PlayMusic();

        // Turning off.
        radioContext.TurnOff();
    }
}
