class SystemCaretaker
{
    private CoordinateSystemOriginator _SystemOriginator { get; set; }
    private Stack<IMemento> _Mementos = new Stack<IMemento>();
    public SystemCaretaker(CoordinateSystemOriginator systemOriginator)
    {
        _SystemOriginator = systemOriginator;
    }
    public void DisplayDates()
    {
        foreach (IMemento memento in _Mementos)
        {
            Console.WriteLine(memento.GetCreatedDateTime());
        }
    }

    public void MakeSnapshot()
    {
        _Mementos.Push(_SystemOriginator.GetMemento());
    }

    public void RestoreLastState()
    {
        if (_Mementos.Count > 0)
        {
            _SystemOriginator.RestoreState(_Mementos.Pop());
        }
    }

    public void RollbackToTheBeginning()
    {
        for (int i = 0; i < _Mementos.Count; i++)
        {
            _SystemOriginator.RestoreState(_Mementos.Pop());
        }
    }
}