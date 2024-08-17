namespace Memento;

class Program
{
    static void Main()
    {
        CoordinateSystemOriginator originator = new CoordinateSystemOriginator("Internal State", 0, 0);
        SystemCaretaker caretaker = new SystemCaretaker(originator);

        Console.WriteLine("First Snapshot:");
        caretaker.MakeSnapshot();

        originator.X = 10;
        originator.Y = 99;
        Console.WriteLine("Second Snapshot:");
        caretaker.MakeSnapshot();

        originator.X = 99;
        originator.Y = -99;

        caretaker.RestoreLastState();

        caretaker.RollbackToTheBeginning();
    }
}
