namespace Decorator.PrimaryObject;

/// <summary>
///     Represents the printer that outputs messages to a terminal.
/// </summary>
public sealed class ConsolePrinter : AbstractPrinter
{
    public override void Print(string message)
    {
        Console.WriteLine(message);
    }
}