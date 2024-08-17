
class CoordinateSystemOriginator
{
    public int X { get; set; }
    public int Y { get; set; }
    private string _InternalStateString { get; set; } = String.Empty;
    public CoordinateSystemOriginator(string stateString, int x, int y)
    {
        _InternalStateString = stateString;
        X = x;
        Y = y;
    }

    public void SetInternalStateString(string internalState)
    {
        _InternalStateString = internalState;
    }

    public IMemento GetMemento()
    {
        Console.WriteLine("Returning the current state:");
        DisplayCurrentState();
        Console.WriteLine();
        return new CoordinateSystemMemento(this);
    }

    public void RestoreState(IMemento memento)
    {
        Console.WriteLine("State before restoring: ");
        DisplayCurrentState();
        Console.WriteLine();

        CoordinateSystemMemento? savedState = memento as CoordinateSystemMemento;
        if (savedState is null)
        {
            throw new InvalidOperationException("Provide a valid memento.");
        }
        X = savedState._X;
        Y = savedState._Y;
        _InternalStateString = savedState._InternalStateString;

        Console.WriteLine("State After: ");
        DisplayCurrentState();
        Console.WriteLine();
    }

    private void DisplayCurrentState()
    {
        Console.WriteLine($"X is {X}");
        Console.WriteLine($"Y is {Y}");
        Console.WriteLine($"Internal State String is {_InternalStateString}");
    }

    class CoordinateSystemMemento : IMemento
    {
        internal int _X { get; set; }
        internal int _Y { get; set; }
        internal string _InternalStateString { get; set; } = String.Empty;
        private DateTime _CreatedOn { get; set; } = DateTime.Now;
        private CoordinateSystemMemento() { }
        public CoordinateSystemMemento(CoordinateSystemOriginator systemOriginator)
        {
            _X = systemOriginator.X;
            _Y = systemOriginator.Y;
            _InternalStateString = systemOriginator._InternalStateString;
        }
        public DateTime GetCreatedDateTime()
        {
            return _CreatedOn;
        }
    }
}